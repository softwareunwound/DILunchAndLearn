using LunchAndLearnDI.Contracts;
using LunchAndLearnDI.Entities;

namespace LunchAndLearnDI.Domain
{
    public class NewAndBetterPricingService:IPriceProducts
    {
        public decimal GetLatestPrice(Product price)
        {
            return 1000000m;
        }
    }
}