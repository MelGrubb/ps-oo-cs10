using System.ComponentModel.DataAnnotations;

namespace RepairShop.Domain.Model.Entities
{
    public class Customer
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string FirstName {  get; set; } = null!;

        [MaxLength(50)]
        public string LastName { get; set; } = null!;

        [MaxLength(20)]
        public string PhoneNumber { get; set; } = null!;

        public ICollection<Vehicle> Vehicles { get; set; } = new HashSet<Vehicle>();
    }
}
