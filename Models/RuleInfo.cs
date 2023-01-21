using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDroneMobile
{
    public class Parameters
    {
        public int maintenance_mileage_interval { get; set; }
        public string maintenance_due_date { get; set; }
    }

    public class RuleInfo
    {
        public int id { get; set; }
        public int vehicle_id { get; set; }
        public int user_id { get; set; }
        public string type { get; set; }
        public List<string> alert_type { get; set; }
        public bool enabled { get; set; }
        public object email { get; set; }
        public object phone_number { get; set; }
        public Parameters parameters { get; set; }
    }
}
