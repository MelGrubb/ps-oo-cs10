using Microsoft.EntityFrameworkCore;
using RepairShop.Domain.Model;
using RepairShop.Domain.Model.Entities;
using RepairShop.Domain.Services;

namespace RepairShop.Tests
{
    [TestFixture]
    public abstract class Given_a_QuoteService
    {
        protected RepairShopContext Context { get; set; } = null!;
        protected IQuoteService SUT { get; set; }
        protected RepairOrder RepairOrder { get; set; }
        protected WarrantyService WarrantyService { get; set; }

        [SetUp]
        public virtual void SetUp()
        {
            Context = new RepairShopContext();
            Context.Database.EnsureDeleted();
            Context.Database.EnsureCreated();

            WarrantyService = new WarrantyService
            {
                Warranties =
                {
                    new BumperToBumperWarranty(),
                    new PowertrainWarranty(),
                    new EmissionsWarranty()
                }
            };

            RepairOrder = new RepairOrder
            {
                Vehicle = new Vehicle
                {
                    Customer = new Customer
                    {
                        FirstName = "John",
                        LastName = "Doe",
                        PhoneNumber = "987654321"
                    },
                    Year = 2010,
                    Make = "Ford",
                    Model = "Focus",
                    Odometer = 50000
                },   
                Repairs = { Context.Repairs.Include(x => x.Parts).Single(x => x.Code == "OC001") }
            };

            Context.RepairOrders.Add(RepairOrder);
            Context.SaveChanges();

            SUT = new QuoteService(Context, 100, WarrantyService);
        }
    }
}
