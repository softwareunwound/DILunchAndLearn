using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LunchAndLearnDI.Contracts;
using LunchAndLearnDI.Entities;
using System.Data.Entity;

namespace LunchAndLearnDI.DataAccess
{
    /// <summary>
    /// Concrete implementation of IProductsRepository
    /// Uses DbContext under the covers 
    /// </summary>
    public class EfProductsRepository : IProductsRepository, IDisposable
    {
        private readonly NorthwindContext _context = new NorthwindContext();

        /// <summary>
        /// Gets the products.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Product> GetProducts()
        {
            return _context.Products.ToList();
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            //var match = _context.Products.Select(p => p).AsQueryable();
            var products = await _context.Set<Product>().Select(p => p).ToListAsync().ConfigureAwait(false);
            return products;
        }

        /// <summary>
        /// Gets the product.
        /// </summary>
        /// <param name="productId">The product identifier.</param>
        /// <returns></returns>
        public Product GetProduct(int productId)
        {
            return _context.Products.SingleOrDefault(p => p.ProductId == productId);
        }

        /// <summary>
        /// Updates the product.
        /// </summary>
        /// <param name="product">The product.</param>
        public void UpdateProduct(Product product)
        {
            //var product = this.GetProduct(productId);
            //product.UnitPrice = price;
            _context.SaveChanges();
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!disposing) return;
            if (_context != null)
            {
                _context.Dispose();
            }
        }
    }
}