namespace Demo
{
    public sealed class IceControlModule : EngineControlModule
    {
        private int engineStatus;

        public CrankPositionSensor CrankPositionSensor { get; set; } = new CrankPositionSensor();
        public ExhaustOxygenSensor ExhaustOxygenSensor { get; set; } = new ExhaustOxygenSensor();
        public override bool IsRunning => engineStatus == 1;

        public IceControlModule()
        {
            EngineType = EngineType.Gasoline;
        }

        public override void Start()
        {
            // Crank the starter
            engineStatus = 1;
        }

        public override void Stop()
        {
            // Cut the power
            engineStatus = 0;
        }
    }
}