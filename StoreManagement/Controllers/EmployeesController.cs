using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ApplicationCore.Services;

namespace StoreManagement.Controllers
{
    public class EmployeesController : Controller
    {

        private readonly IEmployeeService employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService ?? throw new ArgumentNullException("employeeService");
        }
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }

        // GET: Employees
        public ActionResult Index()
        {
            return View();
        }
    }
}