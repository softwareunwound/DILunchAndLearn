using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LunchAndLearnDI.Contracts;
using LunchAndLearnDI.Entities;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace LunchAndLearnDI.DataAccess
{
    /// <summary>
    /// Concrete implementation of IProductsRepository
    /// Uses MongoDB
    /// </summary>
    public class MongoProductsRepository : IProductsRepository
    {
        private readonly string _connectionString;
        private readonly MongoClient _client;
        private readonly MongoDatabase _database;
        private readonly MongoServer _server;
        private readonly MongoCollection<Product> _collection;

        /// <summary>
        /// Initializes a new instance of the <see cref="MongoProductsRepository"/> class.
        /// </summary>
        public MongoProductsRepository()
        {
            _connectionString = "mongodb://localhost";
            _client = new MongoClient(_connectionString);
            _server = _client.GetServer();
            _database = _server.GetDatabase("test");
            _collection = _database.GetCollection<Product>("products");
        }

        /// <summary>
        /// Gets the products.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Product> GetProducts()
        {
            var products = _collection.FindAll().Select(p => new Product
            {
                ProductId = p.ProductId,
                Name = p.Name,
                SupplierId = p.SupplierId,
                CategoryId = p.CategoryId,
                QuantityPerUnit = p.QuantityPerUnit,
                UnitPrice = p.UnitPrice,
                UnitsInStock = p.UnitsInStock,
                
                
            });

            return products.OrderBy(p => p.ProductId).ToList();
        }

        //public async Task<IEnumerable<Product>> GetProductsAsync()
        //{
        //    //var products = _collection.FindAll().Select(p => new Product
        //    //{
        //    //    ProductId = p.ProductId,
        //    //    Name = p.Name,
        //    //    SupplierId = p.SupplierId,
        //    //    CategoryId = p.CategoryId,
        //    //    QuantityPerUnit = p.QuantityPerUnit,
        //    //    UnitPrice = p.UnitPrice,
        //    //    UnitsInStock = p.UnitsInStock,


        //    //});

        //    var products = await _collection.FindAllA

        //    // don't leak the abstraction
        //    return products.OrderBy(p => p.ProductId).ToList();
        //}

        /// <summary>
        /// Gets the product.
        /// </summary>
        /// <param name="productId">The product identifier.</param>
        /// <returns></returns>
        public Product GetProduct(int productId)
        {
            var query = Query<Product>.EQ(p => p.ProductId, productId);
            var product = _collection.FindOne(query);
            return product;
        }


        /// <summary>
        /// Seeds the mongo database.
        /// </summary>
        public void SeedMongoDb()
        {
            var efRepo = new EfProductsRepository();
            var products = efRepo.GetProducts();
            foreach (var p in products)
            {
                p._id = p.ProductId;
                this.UpdateProduct(p);
            }
        }

        /// <summary>
        /// Updates the product.
        /// </summary>
        /// <param name="product">The product.</param>
        public void UpdateProduct(Product product)
        {
            if (product == null) return;

            var query = Query<Product>.EQ(p => p.ProductId, product.ProductId);
            var existingProduct = _collection.FindOne(query);

            if (existingProduct == null) this.InsertProduct(existingProduct);        // Todo: Figure out how I want to handle

            _collection.Save(product);

        }

        /// <summary>
        /// Inserts the product.
        /// </summary>
        /// <param name="product">The product.</param>
        public void InsertProduct(Product product)
        {
            if (product == null) return;
            var query = Query<Product>.EQ(p => p.ProductId, product.ProductId);
            var tempProduct = _collection.FindOne(query);
            if (tempProduct == null)
            {
                _collection.Insert(product);

            }
        }

    }
}