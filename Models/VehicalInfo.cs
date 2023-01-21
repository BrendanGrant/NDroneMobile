using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDroneMobile
{
    public class Controller
    {
        public bool armed { get; set; }
        public bool door_open { get; set; }
        public bool trunk_open { get; set; }
        public bool hood_open { get; set; }
        public bool engine_on { get; set; }
        public bool ignition_on { get; set; }
        public bool reservation_status { get; set; }
        public bool timer_start_enabled { get; set; }
        public bool siren_enabled { get; set; }
        public bool shock_sensor_enabled { get; set; }
        public bool turbo_timer_start_enabled { get; set; }
        public bool passive_arming_enabled { get; set; }
        public bool valet_mode_enabled { get; set; }
        public bool auto_door_lock_enabled { get; set; }
        public bool drive_lock_enabled { get; set; }
        public double current_temperature { get; set; }
        public double main_battery_voltage { get; set; }
    }

    public class CustomFields
    {
        public object field_1 { get; set; }
        public object field_2 { get; set; }
        public object field_3 { get; set; }
        public object field_4 { get; set; }
        public object field_5 { get; set; }
    }

    public class CustomUi
    {
        public List<Page> pages { get; set; }
        public string layout_name { get; set; }
    }

    public class HardwiredConfiguration
    {
        public bool hardwired_mode { get; set; }
        public string poc_1_label { get; set; }
        public string poc_2_label { get; set; }
        public string poc_3_label { get; set; }
        public string pic_1_label { get; set; }
    }

    public class IOStatus
    {
        public int poc_1_configuration { get; set; }
        public int poc_2_configuration { get; set; }
        public int poc_3_configuration { get; set; }
        public int pic_1_configuration { get; set; }
        public bool fota_status { get; set; }
        public bool backup_battery_status { get; set; }
    }

    public class Keylocker
    {
        public object keylocker_roof_open { get; set; }
        public object keylocker_key_present { get; set; }
        public object keylocker_button_disabled { get; set; }
        public object keylocker_button_is_controllable { get; set; }
        public object keylocker_armed { get; set; }
        public object remote_disarms_keylocker { get; set; }
        public object mode { get; set; }
        public object version { get; set; }
    }

    public class LastKnownState
    {
        public IOStatus i_o_status { get; set; }
        public string imei { get; set; }
        public string iccid { get; set; }
        public string carrier { get; set; }
        public string ble_mac_address { get; set; }
        public string firmware_version { get; set; }
        public int ble_firmware_version { get; set; }
        public string controller_model { get; set; }
        public double controller_version { get; set; }
        public int current_cellular_network { get; set; }
        public int cellular_signal_strength { get; set; }
        public double backup_battery_voltage { get; set; }
        public DateTime timestamp { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public double speed { get; set; }
        public string gps_direction { get; set; }
        public double gps_degree { get; set; }
        public double mileage { get; set; }
        public Controller controller { get; set; }
    }

    public class LocalEventRules
    {
    }

    public class Location1
    {
        public string control { get; set; }
    }

    public class Location2
    {
        public string control { get; set; }
    }

    public class Location3
    {
        public string icon { get; set; }
        public string control { get; set; }
    }

    public class Page
    {
        public Location1 location_1 { get; set; }
        public Location2 location_2 { get; set; }
        public Location3 location_3 { get; set; }
    }

    public class PricingPlan
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public string billing_model { get; set; }
        public bool local_events { get; set; }
        public bool location_services { get; set; }
        public bool motion_reporting { get; set; }
        public bool audit_log { get; set; }
        public bool trip_reporting { get; set; }
        public bool dtc_events { get; set; }
        public bool speed_limit_api { get; set; }
        public bool autorenewal { get; set; }
        public string image { get; set; }
        public bool is_trial { get; set; }
        public DateTime plan_activation_date { get; set; }
        public DateTime plan_renewal_date { get; set; }
    }

    public class VehicalInfo
    {
        public string id { get; set; }
        public string device_key { get; set; }
        public string vin { get; set; }
        public string vehicle_make { get; set; }
        public string vehicle_name { get; set; }
        public DateTime create_date { get; set; }
        public DateTime update_date { get; set; }
        public DateTime last_movement_timestamp { get; set; }
        public int runtime { get; set; }
        public int initial_runtime { get; set; }
        public string vehicle_model { get; set; }
        public string vehicle_license_plate { get; set; }
        public object vehicle_year { get; set; }
        public int subscriber_id { get; set; }
        public string image { get; set; }
        public LastKnownState last_known_state { get; set; }
        public CustomFields custom_fields { get; set; }
        public bool towing_detected { get; set; }
        public object crash_detected { get; set; }
        public object dtc_codes { get; set; }
        public object dtc_error_count { get; set; }
        public object hard_braking { get; set; }
        public object hard_cornering { get; set; }
        public object harsh_acceleration { get; set; }
        public bool normal_start_mode_status { get; set; }
        public bool panic_status { get; set; }
        public bool remote_start_status { get; set; }
        public bool tach_learning_status { get; set; }
        public bool temperature_start_mode_status { get; set; }
        public bool timer_start_mode_status { get; set; }
        public bool trigger_start_mode_status { get; set; }
        public bool turbo_start_mode_status { get; set; }
        public bool turbo_status { get; set; }
        public bool battery_off { get; set; }
        public bool battery_reconnected { get; set; }
        public bool low_battery { get; set; }
        public bool service_due { get; set; }
        public double starting_mileage { get; set; }
        public PricingPlan pricing_plan { get; set; }
        public bool is_pending_transfer { get; set; }
        public object new_pending_owner { get; set; }
        public HardwiredConfiguration hardwired_configuration { get; set; }
        public Keylocker keylocker { get; set; }
        public Touchpad touchpad { get; set; }
        public LocalEventRules local_event_rules { get; set; }
        public bool in_geofence { get; set; }
        public object dealer_profile { get; set; }
        public List<object> current_geofences { get; set; }
        public CustomUi custom_ui { get; set; }
    }

    public class Touchpad
    {
        public bool master_pin_set { get; set; }
        public object master_pin_encrypted { get; set; }
        public bool secondary_pin_set { get; set; }
        public object secondary_pin_encrypted { get; set; }
        public object secondary_pin_start_date { get; set; }
        public object secondary_pin_end_date { get; set; }
        public bool is_touchpad_secondary_pin_shared { get; set; }
    }
}
