using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainClassLibrary.ApplicationsServices;

namespace DomainClassLibrary.DAL
{
  class EmployeeInfoEntityConfiguration: EntityTypeConfiguration<EmployeeInfo>
  {
    public EmployeeInfoEntityConfiguration()
    {
     

    }
  }
}
