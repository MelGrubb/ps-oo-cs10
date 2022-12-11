namespace Demo
{
    public class RemoteStarter
    {
        private IStartable _device;

        public RemoteStarter(IStartable device)
        {
            _device = device;
        }

        public void Start() => _device.Start();
        public void Stop() => _device.Stop();
    }
}
