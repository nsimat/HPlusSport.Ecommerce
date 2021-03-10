using HPlusSport.Ecommerce.Controllers;
using HPlusSport.Ecommerce.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace HPlusSport.Ecommerce.Tests.Controllers
{
    [TestClass]
    public class ProductControllerTest
    {
        [TestMethod]
        public void GetProductDetail()
        {
            // Arrange
            var controller = new ProductController();

            // Act
            var result = controller.Detail("womens-winter-jacket") as ViewResult;

            // Assert
            var product = (Product)result.ViewBag.Product;
            Assert.AreEqual("Women's Winter Jacket", product.Name);
        }
    }
}
