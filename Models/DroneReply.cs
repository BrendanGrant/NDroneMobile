using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDroneMobile
{
    public class DroneReply<T>
    {
        public int count { get; set; }
        public object next { get; set; }
        public object previous { get; set; }
        public List<T> results { get; set; }
    }
}
