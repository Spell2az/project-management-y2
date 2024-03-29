﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Domain;
using DAL.EntityConfigurations;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.SqlServer.Server;

namespace DAL
{
  public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
  {
    public ApplicationDbContext()
      : base("SolutionConnection", throwIfV1Schema: false)
    {
    }

    public static ApplicationDbContext Create()
    {
      return new ApplicationDbContext();
    }

      protected override void OnModelCreating(DbModelBuilder modelBuilder)
      {
          base.OnModelCreating(modelBuilder);

          modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
          modelBuilder.Configurations.Add(new ApplicationUserEntityConfiguration());
      }

      public DbSet<Product> Products { get; set; }
      public DbSet<EmployeeInfo> EmployeeInfos { get; set; }
      public DbSet<WarehouseLocation> WarehouseLocations { get; set; }
    }
}
