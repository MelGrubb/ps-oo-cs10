namespace Demo
{
    internal class IceControlModule : EngineControlModule
    {
        private CrankPositionSensor _crankPositionSensor = new CrankPositionSensor();

        internal override void Start()
        {
            // Crank the starter
            Status = 1;
        }

        internal override void Stop()
        {
            // Cut the power
            Status = 0;
        }
    }
}
