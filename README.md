# NDroneMobile

Very scrappy, this client enables persons with a Drone Mobile (https://www.dronemobile.com/) remote starter with a subscription the ability to trigger locks/unlocks/starts from afar via this code, as simple as:

            var client = new NDroneMobileClient(logger);
            string username = "";
            string password = "";
            string deviceId = "";
            await client.Login(username, password, deviceId);
            
            /*
            //Interesting implemented commands, but not actually needed
            var user = await client.GetUser();
            var vehical = await client.GetVehicle();
            var device = await client.GetDevice();
            var rules = await client.GetRules();
            */

            var unlockSuccess = await c.SendCommand(Commands.UNLOCK);
            //or
            var lockSuccess = await c.SendCommand(Commands.LOCK);
            //or
            var startSuccess = await c.SendCommand(Commands.STARTSTOP);

This is currently in use by a custom Alexa skill of mine which will open my garage door, and then start my vehicle, all with a single voice command.