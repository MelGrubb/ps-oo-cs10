namespace RepairShop.Domain.Model.Entities
{
    public class RepairOrder
    {
        public int Id { get; set; }
        public Vehicle Vehicle { get; set; } = null!;
        public ICollection<Repair> Repairs { get; set; } = new HashSet<Repair>();
    }
}
