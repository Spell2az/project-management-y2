using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using DomainClassLibrary.ApplicationsServices;
using ManagementApp.DAL;
using ManagementApp.Models;
using Microsoft.Ajax.Utilities;
using AppContext = ManagementApp.DAL.AppContext;

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
        public async Task<ActionResult> Login(LoginViewModel model)
        {
              if (!ModelState.IsValid)
              {
                  return View(model);
              }

                var authService = new UserService(new AppContext());
              var loginValid = await authService.CheckLogin(model.Email, model.Password);
              if (!loginValid)
              {
                 AddError("Invalid username or password");
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