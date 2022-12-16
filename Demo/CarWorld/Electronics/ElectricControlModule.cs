using Demo.CarWorld.Enumerations;
using Demo.CarWorld.Sensors;

namespace Demo.CarWorld.Electronics
{
    public sealed class ElectricControlModule : EngineControlModule
    {
        private int _relayStatus;

        public CrankPositionSensor CrankPositionSensor { get; set; } = new CrankPositionSensor();
        public ExhaustOxygenSensor ExhaustOxygenSensor { get; set; } = new ExhaustOxygenSensor();
        public override bool IsRunning => _relayStatus == 1;

        public ElectricControlModule()
        {
            EngineType = EngineType.Electric;
        }

        public override void Start()
        {
            // Close some relays
            _relayStatus = 1;
        }

        public override void Stop()
        {
            // Open some relays
            _relayStatus = 0;
        }
    }
}