using LunchAndLearnDI.Contracts;
using LunchAndLearnDI.Entities;

namespace LunchAndLearnDI.Domain
{
    /// <summary>
    /// Uses proprietary algorithms 
    /// to Calculate what the unit price of a product should be
    /// </summary>
    public class PricingCalculator : IPriceProducts
    {

        /// <summary>
        /// Gets the latest price.
        /// </summary>
        /// <param name="product">The product.</param>
        /// <returns></returns>
        public decimal GetLatestPrice(Product product)
        {
            if (product.UnitPrice == null) return 0.00m;
            var price = product.UnitPrice.Value + product.UnitPrice.Value*.005m;
            return price;
        }
    }
}