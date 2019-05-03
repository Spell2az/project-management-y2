using System.Collections.Generic;
using ApplicationCore.Domain;

namespace ApplicationCore.Services
{
    public interface IEmployeeService
    {
        IEnumerable<ApplicationUser> GetEmployees();
    }
}