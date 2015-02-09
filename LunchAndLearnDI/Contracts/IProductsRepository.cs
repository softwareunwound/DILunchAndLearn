using System.Collections.Generic;
using LunchAndLearnDI.Entities;

namespace LunchAndLearnDI.Contracts
{
    public interface IProductsRepository
    {
        IEnumerable<Product> GetProducts();

        Product GetProduct(int productId);

        void UpdateProduct(Product product);
    }
}