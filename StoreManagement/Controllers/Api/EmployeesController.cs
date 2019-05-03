using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using ApplicationCore.Services;
using Microsoft.AspNet.Identity.Owin;
using StoreManagement.Dtos;

namespace StoreManagement.Controllers.Api
{
    public class EmployeesController : ApiController
    {
        private readonly IEmployeeService employeeService;

        public EmployeesController()
        {
            this.employeeService = new EmployeeService(HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>()); 
        }
        // GET api/<controller>
        public IHttpActionResult GetEmployees()
        {
            var employees = employeeService.GetEmployees().Select(e => new EmployeeDto()
            {
                Id = e.Id,
                UserName = e.UserName,
                Receive = e.EmployeeInfo.Receive,
                Stow = e.EmployeeInfo.Stow,
                Pick = e.EmployeeInfo.Pick,
                Pack = e.EmployeeInfo.Pack,
                Ship = e.EmployeeInfo.Ship
            });
            return Ok(employees);
        }

     
    }
}