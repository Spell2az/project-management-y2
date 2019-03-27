using System.Data.Entity;
using DomainClassLibrary.ApplicationsServices;
using DomainClassLibrary.DAL;
using DomainClassLibrary.Entities;

namespace ManagementApp.DAL
{
    public class AppContext : DbContext
    {
        public AppContext() : base("AppContext")
        {
            
        }

      protected override void OnModelCreating(DbModelBuilder modelBuilder)
      {
        modelBuilder.Configurations.Add(new UserEntityConfiguration());
        base.OnModelCreating(modelBuilder);
      }

      public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<EmployeeInfo> EmployeeInfos { get; set; }


    }
}