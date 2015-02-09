using LunchAndLearnDI.Entities;

namespace LunchAndLearnDI.Contracts
{
    public interface IPriceProducts
    {
        decimal GetLatestPrice(Product price);
    }
}