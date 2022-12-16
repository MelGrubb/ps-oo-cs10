namespace Demo.CarWorld
{
    public class Generator : IStartable
    {
        public bool IsRunning { get; private set; }

        public void Start() => IsRunning = true;

        public void Stop() => IsRunning = false;
    }
}
