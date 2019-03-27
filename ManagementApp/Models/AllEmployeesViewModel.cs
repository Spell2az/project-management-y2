using System.Collections;
using System.Collections.Generic;
using DomainClassLibrary.ApplicationsServices;

namespace ManagementApp.Models
{
  public class AllEmployeesViewModel
  {
    public IList<User> Employees { get; set; }
  }
}