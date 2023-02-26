using RepairShop.Domain.Model.Entities;

namespace RepairShop.Domain.Services
{
    public interface IQuoteService
    {
        Quote? GenerateQuote(int repairOrderId);
    }
}