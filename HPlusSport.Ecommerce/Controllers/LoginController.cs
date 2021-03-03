using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace HPlusSport.Ecommerce.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string userName, string password)
        {
            if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(password))
            {
                FormsAuthentication.SetAuthCookie(userName, false);
                return Redirect(FormsAuthentication.GetRedirectUrl(userName, false));
            }
            return View();
        }
    }
}