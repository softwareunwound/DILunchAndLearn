using System.Collections.Generic;
using LunchAndLearnDI.Contracts;
using LunchAndLearnDI.Controllers;
using LunchAndLearnDI.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace UnitTestProject1
{
    [TestClass]
    public class GoodProductsControllerTests
    {
        [TestMethod]
        public void GoodProductsController_GetProducts_CallsRepoGetProducts()
        {
            // Arrange
            var products = new List<Product>
            {
                new Product {ProductId = 1},
                new Product {ProductId = 2}
            };

            var mockProductRepository = new Mock<IProductsRepository>();
            mockProductRepository.Setup(r => r.GetProducts()).Returns(products);
            var mockPricingCalculator = new Mock<IPriceProducts>();
            
            var target = new GoodProductsController(mockProductRepository.Object, mockPricingCalculator.Object);
            
            // Act
            var result = target.GetProducts();

            // Assert
            Assert.IsNotNull(result);
            mockProductRepository.Verify(r => r.GetProducts());
        }
    }
}
