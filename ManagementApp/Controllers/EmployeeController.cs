using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using ManagementApp.Models;

namespace ManagementApp.Controllers
{
  public class EmployeeController : Controller
  {
    // GET: Employee
    [HttpGet]
    public ActionResult Index()
    {
      return View();
    }


    [HttpGet]
    public ActionResult Edit(int id)
    {

      return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(EmployeeViewModel model)
    {
     
      return View();
    }





  }
}