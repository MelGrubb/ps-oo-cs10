using RepairShop.Domain.Model;
using RepairShop.Domain.Model.Entities;

namespace RepairShop.Domain.Services
{
    public class QuoteService : IQuoteService
    {
        private readonly decimal laborRate;

        public QuoteService(RepairShopContext context, decimal laborRate)
        {
            Context = context;
            this.laborRate = laborRate;
        }

        public RepairShopContext Context { get; init; }

        public Quote? GenerateQuote(int repairOrderId)
        {
            var repairOrder = Context.RepairOrders.SingleOrDefault(x => x.Id == repairOrderId);

            if (repairOrder == null)
            {
                return null;
            }

            var quote = new Quote
            {
                RepairOrder = repairOrder,
                PartTotal = repairOrder.Repairs.Sum(x => x.Parts.Sum(y => y.Price)),
                LaborTotal = repairOrder.Repairs.Sum(x => x.Labor) * laborRate,
                ExpiryDate = DateTime.Today.AddDays(30)
            };

            Context.Quotes.Add(quote);
            Context.SaveChanges();

            return quote;
        }
    }
}
