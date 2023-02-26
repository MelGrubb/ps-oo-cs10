namespace RepairShop.Domain.Model.Entities
{
    public class Quote
    {
        public int Id { get; set; }
        public RepairOrder RepairOrder { get; set; } = null!;
        public decimal PartTotal { get; set; }
        public decimal LaborTotal { get; set; }
        public DateTime ExpiryDate { get; set; }

        public override string ToString()
        {
            var vehicle = RepairOrder.Vehicle;
            var customer = vehicle.Customer;

            return $@"Repair Quote #{Id}, Valid through {ExpiryDate:D}
Prepared for {customer.FirstName} {customer.LastName}'s {vehicle.Year} {vehicle.Make} {vehicle.Model}.
---
Parts: {PartTotal:F}
Labor: {LaborTotal:F}
---
Total: {PartTotal + LaborTotal:F}";
        }
    }
}
