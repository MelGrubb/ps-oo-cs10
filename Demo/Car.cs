namespace Demo
{
    public class Car : IStartable
    {
        public string Make { get; set; } = "";
        public string Model { get; set; } = "";
        public EngineControlModule EngineControlModule { get; set; }
        public bool IsRunning => EngineControlModule.IsRunning;

        public BrakePedal BrakePedal { get; set; } = new BrakePedal();
        public SteeringWheel SteeringWheel { get; set; } = new SteeringWheel();
        public Throttle Throttle { get; set; } = new Throttle();

        public Car(EngineControlModule engineControlModule)
        {
            EngineControlModule = engineControlModule;
        }

        public void Start() => EngineControlModule.Start();
        public void Stop() => EngineControlModule.Stop();
    }
}
