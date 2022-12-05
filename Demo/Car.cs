namespace Demo
{
    public class Car
    {
        private int _status = 0;

        public string Make { get; set; } = "";
        public string Model { get; set; } = "";
        public EngineType EngineType { get; set; }
        public bool IsRunning => _status == 1;
        
        public float AirTemperature { get; set; }
        public float BrakePosition { get; set; }
        public float CrankPosition { get; set; }
        public float ExhaustOxygen { get; set; }
        public float SteeringWheelPosition { get; set; }
        public float ThrottlePosition { get; set; }

        public void Start()
        {
            switch (EngineType)
            {
                case EngineType.Electric:
                    // Close some relays
                    _status = 1;
                    break;
                case EngineType.Gasoline:
                    // Crank the starter
                    _status = 0;
                    break;
            }
        }

        public void Stop()
        {
            switch (EngineType)
            {
                case EngineType.Electric:
                    // Open some relays
                    _status = 0;
                    break;
                case EngineType.Gasoline:
                    // Cut the power
                    _status = 1;
                    break;
            }
        }
    }
}
