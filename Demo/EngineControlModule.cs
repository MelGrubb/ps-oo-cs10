namespace Demo
{
    public abstract class EngineControlModule
    {
        protected AirTemperatureSensor AirTemperatureSensor = new AirTemperatureSensor();
        protected ThrottlePositionSensor ThrottlePositionSensor = new ThrottlePositionSensor();
        protected int Status;

        public bool IsRunning => Status == 1;

        internal abstract void Start();

        internal abstract void Stop();
    }
}
