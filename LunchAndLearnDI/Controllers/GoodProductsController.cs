using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using LunchAndLearnDI.Contracts;

namespace LunchAndLearnDI.Controllers
{
    /// <summary>
    /// Controller that uses constructor injection
    /// OCP and Stragety Pattern
    /// </summary>
    public class GoodProductsController : Controller
    {
        private readonly IProductsRepository _productsRepository;
        private readonly IPriceProducts _priceCalculator;

        /// <summary>
        /// Initializes a new instance of the <see cref="GoodProductsController"/> class.
        /// </summary>
        /// <param name="productsRepository">The products repository.</param>
        /// <param name="priceCalculator">The price calculator.</param>
        /// <exception cref="System.ArgumentNullException">
        /// productsRepository
        /// or
        /// priceCalculator
        /// </exception>
        public GoodProductsController(IProductsRepository productsRepository, IPriceProducts priceCalculator)
        {
            if (productsRepository == null) throw new ArgumentNullException("productsRepository");
            if (priceCalculator == null) throw new ArgumentNullException("priceCalculator");

            _productsRepository = productsRepository;
            _priceCalculator = priceCalculator;
        }
        // GET: GoodProducts
        /// <summary>
        /// Indexes this instance.
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var products = _productsRepository.GetProducts();
            return View("~/Views/Products/Index.cshtml", products);
        }

        public ActionResult GetProducts()
        {
            var products = _productsRepository.GetProducts();
            return View("~/Views/Products/Index.cshtml", products);
        }

        /// <summary>
        /// Gets the product.
        /// </summary>
        /// <param name="productId">The product identifier.</param>
        /// <returns></returns>
        public string GetProduct(int productId)
        {
            var product = _productsRepository.GetProduct(productId);
            return product != null ? product.Name : "no such product";
        }

        /// <summary>
        /// Updates the product price.
        /// </summary>
        /// <param name="productId">The product identifier.</param>
        /// <returns></returns>
        public string UpdateProductPrice(int productId)
        {
            var product = _productsRepository.GetProduct(productId);
            var price = _priceCalculator.GetLatestPrice(product);
            product.UnitPrice = price;
            _productsRepository.UpdateProduct(product);
            return string.Format("Successfully updated product {0}", productId);
        }
    }
}