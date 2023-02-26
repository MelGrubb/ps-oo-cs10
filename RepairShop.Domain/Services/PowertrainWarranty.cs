using RepairShop.Domain.Model.Entities;

namespace RepairShop.Domain.Services
{
    public class PowertrainWarranty : Warranty
    {
        public PowertrainWarranty()
        {
            Duration = 10;
            Odometer = 100000;
        }

        public override bool IsCovered(Vehicle vehicle, Repair repair)
        {
            if (vehicle.Year + Duration < DateTime.Now.Year || vehicle.Odometer > Odometer)
            {
                return false;
            }

            return repair.Category switch
            {
                "Engine" or "Trans" => true,
                _ => false,
            };
        }
    }
}
