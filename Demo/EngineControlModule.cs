namespace Demo
{
    public abstract class EngineControlModule
    {
        public AirTemperatureSensor AirTemperatureSensor { get; set; } = new AirTemperatureSensor();

        public EngineType EngineType { get; set; }
        public abstract bool IsRunning { get; }
        public ThrottlePositionSensor ThrottlePositionSensor { get; set; } = new ThrottlePositionSensor();

        public abstract void Start();
        public abstract void Stop();
    }
}