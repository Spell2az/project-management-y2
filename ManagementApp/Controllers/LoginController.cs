using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ManagementApp.Controllers
{
    public class LoginController : Controller
    {
        // GET: Signin
        public ActionResult Index()
        {
            return View();
        }

      public ActionResult Login()
      {
        return Redirect("~/Dashboard/");
      }
    }
}