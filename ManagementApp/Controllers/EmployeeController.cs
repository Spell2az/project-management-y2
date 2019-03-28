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
    [HttpGet]
    public async Task<ActionResult> Index()
    {
      var employees = await new UserService(new AppContext()).GetEmployees();

      return View(new AllEmployeesViewModel() { Employees = employees });
    }


    [HttpGet]
    public async Task<ActionResult> Edit(int id)
    {
      var employee = await new UserService(new AppContext()).GetUser(id);

      var model = new EmployeeViewModel()
      {
        Id = employee.Id,
        Name = employee.Name,
        Email = employee.Email,
        Receive = employee.EmployeeInfo.Receive,
        Stow = employee.EmployeeInfo.Stow,
        Pick = employee.EmployeeInfo.Pick,
        Pack = employee.EmployeeInfo.Pack,
        Ship = employee.EmployeeInfo.Ship,
      };
      return View(model);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<ActionResult> Edit(EmployeeViewModel model)
    {
      if (!ModelState.IsValid)
      {
        return View(model);
      }

      var service = new UserService(new AppContext());

      var employee = await service.GetUser(model.Id);

      employee.Email = model.Email;
      employee.Name = model.Name;
      employee.EmployeeInfo.Receive = model.Receive;
      employee.EmployeeInfo.Stow = model.Stow;
      employee.EmployeeInfo.Pick = model.Pick;
      employee.EmployeeInfo.Pack = model.Pack;
      employee.EmployeeInfo.Ship = model.Ship;

      await service.UpdateEmployeeRecord(employee);

      return View(model);
    }





  }
}