namespace Demo
{
    public class EC1 : Car
    {
        public EC1()
        {
            Make = "Globomantics";
            Model = "EC1";
            EngineControlModule = new ElectricControlModule();
        }
    }
}
