using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using ApplicationCore.Domain;
using ApplicationCore.Services;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using StoreManagement.Dtos;
using StoreManagement.Models;

namespace StoreManagement.Controllers
{
    [Authorize(Roles = "Admin")]
    public class EmployeesController : Controller
    {

        //private readonly IEmployeeService employeeService;

        public EmployeesController()
        {
            //this.employeeService = employeeService ?? throw new ArgumentNullException("employeeService");
        }

        // GET: Employees
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(string id)
        {
            var userManager = HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var employee = userManager.FindById(id);
            var employeeDto = new EmployeeDto()
            {
                Id = employee.Id,
                UserName = employee.UserName,
                Receive = employee.EmployeeInfo.Receive,
                Stow = employee.EmployeeInfo.Stow,
                Pick = employee.EmployeeInfo.Pick,
                Pack = employee.EmployeeInfo.Pack,
                Ship = employee.EmployeeInfo.Ship

            };
            return View(employeeDto);
        }

        [HttpGet]
        public ActionResult Edit(string id)
        {
            var userManager = HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var employee = userManager.FindById(id);
            var employeeDto = new EmployeeDto()
            {
                Id = employee.Id,
                UserName = employee.UserName,
                Receive = employee.EmployeeInfo.Receive,
                Stow = employee.EmployeeInfo.Stow,
                Pick = employee.EmployeeInfo.Pick,
                Pack = employee.EmployeeInfo.Pack,
                Ship = employee.EmployeeInfo.Ship

            };
            return View(employeeDto);
        }

        [HttpPost]
        public ActionResult Edit(EmployeeDto employeeDto)
        {
            if (ModelState.IsValid)
            {
                var userManager = HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
                var employee = userManager.FindById(employeeDto.Id);

                employee.UserName = employeeDto.UserName;
                employee.EmployeeInfo.Receive = employeeDto.Receive;
                employee.EmployeeInfo.Stow = employeeDto.Stow;
                employee.EmployeeInfo.Pick = employeeDto.Pick;
                employee.EmployeeInfo.Pack = employeeDto.Pack;
                employee.EmployeeInfo.Ship = employeeDto.Ship;

                userManager.Update(employee);
            }

           

            return RedirectToAction("Details", new { id = employeeDto.Id });
        }

        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(AddEmployeeDto employeeDto)
        {
            if (ModelState.IsValid)
            {
                var userManager = HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
                var employee = new ApplicationUser
                {
                    Id = Guid.NewGuid().ToString(),
                    UserName = employeeDto.Email,
                    Email = employeeDto.Email,
                    EmployeeInfo = new EmployeeInfo()
                    {
                        Receive = employeeDto.Receive,
                        Stow = employeeDto.Stow,
                        Pick = employeeDto.Pick,
                        Pack = employeeDto.Pack,
                        Ship = employeeDto.Ship,
                    }
                };
                var result = await userManager.CreateAsync(employee, employeeDto.Password);
                if (result.Succeeded)
                {
                    userManager.AddToRole(employee.Id, "Employee");

                    return RedirectToAction("Details", new { id = employee.Id });
                    
                }
                AddErrors(result);
            }

           

            return View(employeeDto);
        }

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error);
            }
        }
    }

}
