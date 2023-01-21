using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDroneMobile
{
    public class UserInfo
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string phone_number { get; set; }
        public object postal_code { get; set; }
        public string country { get; set; }
        public object state { get; set; }
        public object city { get; set; }
        public object address { get; set; }
        public object address_2 { get; set; }
        public string language { get; set; }
        public object timezone { get; set; }
        public string image { get; set; }
        public string unlock_pin { get; set; }
        public List<UserType> user_type { get; set; }
        public bool allow_app_analytics { get; set; }
        public bool needs_onboarding { get; set; }
        public List<VehicleAccess> vehicle_access { get; set; }
        public object dealer_id { get; set; }
        public bool is_password_set { get; set; }
        public DateTime custom_ui_last_update_date { get; set; }
        public object custom_filter_last_update_date { get; set; }
    }

    public class UserType
    {
        public int subscriber { get; set; }
        public string type { get; set; }
    }

    public class VehicleAccess
    {
        public int vehicle_permission_id { get; set; }
        public int role { get; set; }
        public int vehicle { get; set; }
        public int subscriber { get; set; }
        public bool exclusive_access { get; set; }
        public DateTime access_start { get; set; }
        public object access_end { get; set; }
        public DateTime shared_date_from { get; set; }
        public object shared_date_to { get; set; }
        public bool is_shared { get; set; }
    }
}
