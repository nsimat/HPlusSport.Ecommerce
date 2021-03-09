using HPlusSport.Ecommerce.Data;
using HPlusSport.Ecommerce.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace HPlusSport.Ecommerce.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            Customer customer = null;

            using(var context = new HPlusSportDbContext())
            {
                var user = context.Users.FirstOrDefault(u => u.EmailAddress == User.Identity.Name);

                if (user != null)
                    customer = context.Customers.FirstOrDefault(c => c.CustomerId == user.CustomerId);

                return View(customer);
            }
            
            
        }        
    }
}