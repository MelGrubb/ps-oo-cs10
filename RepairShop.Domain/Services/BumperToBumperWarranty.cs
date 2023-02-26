using RepairShop.Domain.Model.Entities;

namespace RepairShop.Domain.Services
{
    public class BumperToBumperWarranty : Warranty
    {
        public BumperToBumperWarranty()
        {
            Duration = 5;
            Odometer = 50000;
        }

        public override bool IsCovered(Vehicle vehicle, Repair repair)
        {
            if (vehicle.Year + Duration < DateTime.Now.Year || vehicle.Odometer > Odometer)
            {
                return false;
            }

            return repair.Category switch
            {
                "Engine" or "Trans" or "Emissions" or "Infotainment" => true,
                _ => false,
            };
        }
    }
}
