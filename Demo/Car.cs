namespace Demo
{
    public class Car
    {
        private EngineControlModule _engineControlModule = new EngineControlModule();

        public BrakePedal BrakePedal { get; set; } = new BrakePedal();
        public bool IsRunning => _engineControlModule.IsRunning;
        public string Make { get; set; } = "";
        public string Model { get; set; } = "";
        public SteeringWheel SteeringWheel { get; set; } = new SteeringWheel();
        public Throttle Throttle { get; set; } = new Throttle();

        public void Start()
        {
            _engineControlModule.Start();
        }

        public void Stop()
        {
            _engineControlModule.Stop();
        }
    }
}
