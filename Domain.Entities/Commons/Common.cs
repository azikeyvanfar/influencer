namespace Domain.Entities.Commons
{
    public class Common
    {
    }

    public class CompanySetting
    {
        public float lat { get; set; }

        public float lng { get; set; }

        public int vehicleOff { get; set; }

        public int vehicleDisconnect { get; set; }

        public bool routeDirection { get; set; }

        public bool driver { get; set; }

        public bool simcard { get; set; }

        public bool temprature { get; set; }

        public bool speed { get; set; }

        public bool plaque { get; set; }

        public bool code { get; set; }

        public bool time { get; set; }

        public bool status { get; set; }
    }

    public class CompanySettings
    {
        public CompanySettings()
        {
            TemporaryDisconnectedThreshold = 15;
            DisconnectedThreshold = 1440;
            DisplayItem = "Driver";
        }

        public int TemporaryDisconnectedThreshold { get; set; }

        public int DisconnectedThreshold { get; set; }

        public string DisplayItem { get; set; }
    }

}
