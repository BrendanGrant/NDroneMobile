using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDroneMobile
{
    internal static class URLs
    {
        public const string DRONE_BASE_URL = "https://api.dronemobile.com";
        public const string DRONE_ACCOUNT_BASE_URL = "https://accounts.dronemobile.com";
        public const string DRONE_USER_URL = $"{DRONE_BASE_URL}/api/v1/user";
        public const string DRONE_VEHICLE_URL = $"{DRONE_BASE_URL}/api/v1/vehicle?limit=100";
        public const string DRONE_DEVICE_URL = $"{DRONE_BASE_URL}/api/v1/device/?limit=100";
        public const string DRONE_RULE_URL = $"{DRONE_BASE_URL}/api/v1/alert/rule?limit=100&alert_type=maintenance_due_date&alert_type=maintenance_mileage_interval&vehicle_id=324605";
        public const string DRONE_SEND_COMMAND_URL = $"{DRONE_ACCOUNT_BASE_URL}/api/iot/send-command";
    }
}
