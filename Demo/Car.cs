namespace Demo
{
    public abstract class Car
    {
        public string Make { get; set; } = "";
        public string Model { get; set; } = "";
        public EngineType EngineType { get; set; }
        public bool IsRunning { get; set; }
        public float AirTemperature { get; set; }
        public float BrakePosition { get; set; }
        public float CrankPosition { get; set; }
        public float ExhaustOxygen { get; set; }
        public float SteeringWheelPosition { get; set; }
        public float ThrottlePosition { get; set; }

        public void Start()
        {
            IsRunning = true;
        }

        public void Stop()
        {
            IsRunning = false;
        }
    }
}
