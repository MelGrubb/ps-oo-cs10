using RepairShop.Domain.Model.Entities;

namespace RepairShop.Domain.Services
{
    public class WarrantyService : IWarrantyService
    {
        public List<Warranty> Warranties { get; } = new List<Warranty>();

        public bool IsCovered(Vehicle vehicle, Repair repair)
        {
            return Warranties.Any(x => x.IsCovered(vehicle, repair));
        }
    }
}
