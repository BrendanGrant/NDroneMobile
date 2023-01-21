using Amazon;
using Amazon.CognitoIdentityProvider;
using Amazon.Extensions.CognitoAuthentication;
using Amazon.Runtime;
using RestSharp;
using System.Text.Json;
using Microsoft.Extensions.Logging;
using NDroneMobile.Models;

namespace NDroneMobile
{
    public class NDroneMobileClient
    {
        const string AUTH_BASE_URL = "https://cognito-idp.us-east-1.amazonaws.com";
        const string AUTH_CLIENT_ID = "3l3gtebtua7qft45b4splbeuiu";
        const string AUTH_REGION_ID = "us-east-1";
        const string AUTH_USER_POOL_ID = "us-east-1_wVJW7UHWC";
        const string AUTH_IDENTITY_POOL_ID = "us-east-1:c8505dc2-cd6f-4247-9c66-51da20da1d28";
       

        RestClient client = null;
        string authToken = "";
        string desiredDeviceId = "";
        ILogger logger;

        public NDroneMobileClient(ILogger logger) {
            this.logger = logger;
        }

        public async Task Login(string username, string password, string desiredDeviceId = "")
        {
            this.desiredDeviceId = desiredDeviceId;

            //Optional dev time loading of old auth token
            if (true)
            {
                var provider = new AmazonCognitoIdentityProviderClient(
                    new AnonymousAWSCredentials(), RegionEndpoint.USEast1);
                var pool = new CognitoUserPool(AUTH_USER_POOL_ID, AUTH_CLIENT_ID, provider);
                var user = new CognitoUser(username, AUTH_CLIENT_ID, pool, provider);
                var req = new InitiateSrpAuthRequest() { Password = password };

                var reqRes = await user.StartWithSrpAuthAsync(req);
                authToken = reqRes.AuthenticationResult.IdToken;

                //TODO: Figure out lifetime of token to reduce the need to login so much?
                //File.WriteAllText("authToken.txt", authToken);
            }
            else
            {
                //authToken = File.ReadAllText("authToken.txt").Trim();
            }

            InitClient();
        }

        private void InitClient()
        {
            client = new RestClient();
            client.AddDefaultHeader("Authorization", $"Bearer {authToken}");
        }

        private async Task<DroneReply<T>> GetAsync<T>(string url)
        {
            return await ExecuteAsync<DroneReply<T>>(new RestRequest(url));
        }

        public async Task<T> ExecuteAsync<T>(RestRequest req)
        {
            logger.LogInformation($"Requesting {req.Method} at {req.Resource}");
            var response = await client.ExecuteAsync(req);
            if (response.IsSuccessful == false)
            {
                logger.LogError($"Failed in get: {response.ErrorMessage}");
            }
            else
            {
                //If much more logging is required
                //logger.LogInformation($"Got {response.StatusCode}: {response.Content}");
            }

            if (string.IsNullOrEmpty(response.Content))
            {
                return default(T);
            }

            return JsonSerializer.Deserialize<T>(response.Content);
        }

        public async Task<UserInfo> GetUser()
        {
            logger.LogInformation("GetUser()");
            var userResults = await GetAsync<UserInfo>(URLs.DRONE_USER_URL);
            return userResults.results.FirstOrDefault();
        }

        public async Task<VehicalInfo> GetVehicle()
        {
            logger.LogInformation("GetVehicle()");
            var vehicalResults = await GetAsync<VehicalInfo>(URLs.DRONE_VEHICLE_URL);
            return vehicalResults.results.FirstOrDefault();
        }

        public async Task<DeviceInfo> GetDevice()
        {
            logger.LogInformation("GetDevice()");
            var deviceResults = await GetAsync<DeviceInfo>(URLs.DRONE_DEVICE_URL);
            return deviceResults.results.FirstOrDefault();
        }

        public async Task<RuleInfo> GetRules()
        {
            logger.LogInformation("GetRules()");
            var ruleResults = await GetAsync<RuleInfo>(URLs.DRONE_RULE_URL);
            return ruleResults.results.FirstOrDefault();
        }

        public async Task<bool> SendCommand(string command, string deviceId = "")
        {
            logger.LogInformation($"SendCommand({command}, {deviceId}|{desiredDeviceId})");
            if(string.IsNullOrEmpty(deviceId))
            {
                if (string.IsNullOrEmpty(desiredDeviceId))
                {
                    throw new ArgumentNullException("Must specify DeviceId or DesiredDeviceId");
                }
                deviceId = desiredDeviceId;
            }

            var req = new RestRequest(URLs.DRONE_SEND_COMMAND_URL, Method.Post);
            req.AddJsonBody(new { deviceKey = deviceId, command = command });
            req.AddHeader("x-drone-api", authToken);
            
            var response = await ExecuteAsync<CommandReply>(req);

            return response.parsed.command_success;
        }
    }
}
