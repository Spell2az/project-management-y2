using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Domain;

namespace DAL.EntityConfigurations
{
    class ApplicationUserEntityConfiguration: EntityTypeConfiguration<ApplicationUser>
    {
        public ApplicationUserEntityConfiguration()
        {
            HasOptional(u => u.EmployeeInfo)
                .WithRequired(e => e.User);
        }
    }
}
