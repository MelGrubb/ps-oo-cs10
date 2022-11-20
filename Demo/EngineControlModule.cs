namespace Demo
{
    internal class EngineControlModule
    {
        private ThrottlePositionSensor _throttlePositionSensor = new ThrottlePositionSensor();
        private int _status;

        public bool IsRunning => _status == 1;

        internal void Start()
        {
            _status = 1;
        }

        internal void Stop()
        {
            _status = 0;
        }
    }
}
