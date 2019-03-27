using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using DomainClassLibrary.ApplicationsServices;
using ManagementApp.DAL;
using ManagementApp.Models;
using AppContext = ManagementApp.DAL.AppContext;

namespace ManagementApp.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public async Task<ActionResult> Index()
        {
          var employees = await new UserService(new AppContext()).GetEmployees();
          
          return View(new AllEmployeesViewModel(){Employees = employees});
        }

      
      public ActionResult Edit(int id)
      {
        return View();
      }
    }
}