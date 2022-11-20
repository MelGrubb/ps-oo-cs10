namespace Demo
{
    internal class ElectricControlModule : EngineControlModule
    {
        internal override void Start()
        {
            // Close some relays
            Status = 1;
        }

        internal override void Stop()
        {
            // Open some relays
            Status = 0;
        }
    }
}
