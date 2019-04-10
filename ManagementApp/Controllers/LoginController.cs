using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;


using ManagementApp.Models;
using Microsoft.Ajax.Utilities;


namespace ManagementApp.Controllers
{
  public class LoginController : Controller
  {
    // GET: Signin
    public ActionResult Login()
    {
      return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Login(LoginViewModel model)
    {
      if (!ModelState.IsValid)
      {
        return View(model);
      }

     
      return RedirectToAction("Index", "Dashboard");
    }

    private void AddError(string error)
    {
      ModelState.AddModelError("", error);

    }
  }
}