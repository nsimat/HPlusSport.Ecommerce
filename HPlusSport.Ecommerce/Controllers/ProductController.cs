using HPlusSport.Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HPlusSport.Ecommerce.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View("Index");
        }

        [Route("product/{productName}")]
        public ActionResult Detail(string productName)
        {
            // lookup the product name in the database
            ViewBag.Product = new Product
            {
                Name = "Women's Winter Jacket",
                FullPrice = 20.00M,
                CurrentPrice = 16.00M,
                PercentOff = 20,
                ImagePath = "/Content/Images/Products/1.jpg",
                StarRating = 4
            };

            return View();
        }
    }
}