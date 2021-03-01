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
            return View();
        }

        [Route("product/{productName}")]
        public ActionResult Detail(string productName)
        {
            // lookup the product name in the database
            return View();
        }
    }
}