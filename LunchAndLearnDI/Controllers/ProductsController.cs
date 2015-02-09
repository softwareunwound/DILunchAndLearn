using System.Threading.Tasks;
using System.Web.Mvc;
using LunchAndLearnDI.DataAccess;
using LunchAndLearnDI.Domain;

namespace LunchAndLearnDI.Controllers
{
    /// <summary>
    /// Controller that news up everything
    /// Not really using design patterns or DI
    /// More work to incoroporate newer/better libraries
    /// </summary>
    public class ProductsController : Controller
    {
        private EfProductsRepository _repo;
        // GET: Products
        //public async Task<ActionResult> Index()
        //{
        //    var repo = new EfProductsRepository();
        //    //var products = repo.GetProducts();
        //    var products = await repo.GetProductsAsync().ConfigureAwait(false);
        //    return View(products);
        //}

        public ProductsController()
        {
        }

 
        public ActionResult Index()
        {
            var repo = new EfProductsRepository();
            var products = repo.GetProducts();
            //var products = await repo.GetProductsAsync().ConfigureAwait(false);
            return View(products);
        }

        public string GetProduct(int productId)
        {
            var repo = new EfProductsRepository();
            var product = repo.GetProduct(productId);
            return product != null ? product.Name : "no such product";
        }

        public string UpdateProductPrice(int productId)
        {
            var repo = new EfProductsRepository();
            var pricingCalculator = new PricingCalculator();
            var product = repo.GetProduct(productId);
            var updatedPrice = pricingCalculator.GetLatestPrice(product);
            product.UnitPrice = updatedPrice;
            repo.UpdateProduct(product);
            return string.Format("Successfully updated product {0}", productId);
        }
    }
}