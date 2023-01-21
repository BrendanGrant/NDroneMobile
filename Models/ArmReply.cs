using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDroneMobile.Models
{
    public class ControllerReport
    {
        public bool armed { get; set; }
        public bool auto_door_lock_enabled { get; set; }
        public int current_temperature { get; set; }
        public bool door_open { get; set; }
        public bool drive_lock_enabled { get; set; }
        public bool engine_on { get; set; }
        public bool hood_open { get; set; }
        public bool ignition_on { get; set; }
        public double main_battery_voltage { get; set; }
        public bool passive_arming_enabled { get; set; }
        public bool reservation_status { get; set; }
        public bool shock_sensor_enabled { get; set; }
        public bool siren_enabled { get; set; }
        public bool timer_start_enabled { get; set; }
        public bool trunk_open { get; set; }
        public bool turbo_timer_start_enabled { get; set; }
        public bool valet_mode_enabled { get; set; }
    }

    public class CommandReplyDetails
    {
        public bool arm_status { get; set; }
        public int backup_battery_voltage { get; set; }
        public int cellular_signal_strength { get; set; }
        public string command_name { get; set; }
        public string command_sent { get; set; }
        public bool command_success { get; set; }
        public DateTime command_timestamp { get; set; }
        public ControllerReport controller { get; set; }
        public double gps_degree { get; set; }
        public string gps_direction { get; set; }
        public int gps_status { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public int mileage { get; set; }
        public int speed { get; set; }
        public DateTime timestamp { get; set; }
    }

    public class CommandReply
    {
        public string device_key { get; set; }
        public CommandReplyDetails parsed { get; set; }
    }
}
