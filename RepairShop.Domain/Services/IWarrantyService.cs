using RepairShop.Domain.Model.Entities;

namespace RepairShop.Domain.Services
{
    public interface IWarrantyService
    {
        bool IsCovered(Vehicle vehicle, Repair repair);
    }
}