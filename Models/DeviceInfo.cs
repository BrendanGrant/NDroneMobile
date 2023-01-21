using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDroneMobile
{
    public class DeviceInfo
    {
        public string device_key { get; set; }
        public string product_name { get; set; }
        public string device_state { get; set; }
        public int plan_id { get; set; }
        public bool replacement_order_placed { get; set; }
        public bool hardwired_mode { get; set; }
        public bool service_mode { get; set; }
        public object service_mode_end_date { get; set; }
        public bool device_suspend_eligible { get; set; }
        public object seasonal_pause_start_date { get; set; }
        public object seasonal_pause_resume_date { get; set; }
        public DateTime plan_activation_date { get; set; }
        public DateTime plan_renewal_date { get; set; }
        public bool is_keylocker_present { get; set; }
    }
}
