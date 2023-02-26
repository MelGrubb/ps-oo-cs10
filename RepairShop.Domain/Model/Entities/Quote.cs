namespace RepairShop.Domain.Model.Entities
{
    public class Quote
    {
        public int Id { get; set; }
        public RepairOrder RepairOrder { get; set; } = null!;
        public decimal PartTotal { get; set; }
        public decimal LaborTotal { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
