using RepairShop.Domain.Model.Entities;

namespace RepairShop.Domain.Services
{
    public abstract class Warranty
    {
        public int Duration { get; protected set; }
        public int Odometer { get; protected set; }

        public abstract bool IsCovered(Vehicle vehicle, Repair repair);
    }
}
