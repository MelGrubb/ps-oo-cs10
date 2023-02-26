using System.ComponentModel.DataAnnotations;

namespace RepairShop.Domain.Model.Entities
{
    public class Repair
    {
        public int Id { get; set; }

        [MaxLength(10)]
        public string Code { get; set; } = string.Empty;

        [MaxLength(10)]
        public string Category { get; set; } = string.Empty;

        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;

        public ICollection<Part> Parts { get; set; } = new HashSet<Part>();
        public decimal Labor { get; set; }
    }
}
