﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ApplicationCore.Domain;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ApplicationCore.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly UserManager<ApplicationUser> userManager;
       // private readonly RoleManager<IdentityRole> roleManager;
        public EmployeeService(UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager ?? throw new ArgumentNullException("userManager");
           // this.roleManager = roleManager ?? throw new ArgumentNullException("roleManager");
        }
        public IEnumerable<ApplicationUser> GetEmployees()
        {
            var employees = userManager.Users.Where(u => u.EmployeeInfo != null).Include(u => u.EmployeeInfo);
            return employees;
        }
    }
}