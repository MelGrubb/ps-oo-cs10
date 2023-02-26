namespace RepairShop.Domain.Model.Entities
{
    public class Quote
    {
        public int Id { get; set; }
        public RepairOrder RepairOrder { get; set; } = null!;
        public float PartTotal { get; set; }
        public float LaborTotal { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
