using System.ComponentModel.DataAnnotations;

namespace RepairShop.Domain.Model.Entities
{
    public class Part
    {
        public int Id { get; set; }
        public Repair Repair { get; set; } = null!;

        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(10)]
        public string StockNumber { get; set; } = string.Empty;

        public decimal Price { get; set; }
    }
}
