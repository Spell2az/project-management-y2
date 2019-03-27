using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using DomainClassLibrary.ApplicationsServices;

namespace ManagementApp.DAL
{
    public class ShopDataInitialiser : DropCreateDatabaseAlways<AppContext>
    {
        protected override void Seed(AppContext context)
        {
            #region Users - Admin

            context.Users.Add(new User()
            {
                Id = 1,
                Email = "admin@gmail.com",
              Name = "Felix Admin1",
              Role = "Administrator",
                HashedPassword = "mUwH3oGd0JzL0UVLJ5qPA0YnUol3LMCDi6CcO5Wa7Qg=",
            });

      #endregion

            #region Users - Employees

          context.Users.AddRange(new User[]
          {
            new User()
            {
              Id = 2,
              Email = "emp1@gmail.com",
              Name = "Jacky Emp1",
              Role = "Employee",
              HashedPassword = "6adb3afe399f8b04fc266dcaa2fbd611b0b0c635101bf3bedd80ef063ee0498a",
            },
            new User(){
            Id = 3,
            Email = "emp2@gmail.com",
            Name = "Johny Emp2",
            Role = "Employee",
            HashedPassword = "0ff8f62308e67144e03ff3e032932ff89eea93ce51cb46ac85422dbb5b1db7dd",
          },
            new User(){
            Id = 4,
            Email = "emp3@gmail.com",
            Name = "Oscar Emp3",
            Role = "Employee",
            HashedPassword = "d0b2a89e40303b29c704617035c22a9d4c4454d5cf1b4f3a7f71a88c1c8a91f9",
          }
          });

         // context.SaveChanges();

      #region Employee info
      context.EmployeeInfos.AddRange(new EmployeeInfo[]
          {
            new EmployeeInfo()
            {
              Id = 2,
              Receive = true,
              Stow = true,
              Pick = false,
              Pack = false,
              Ship = false,
            },
            new EmployeeInfo()
            {
              Id = 3,
              Receive = false,
              Stow = false,
              Pick = false,
              Pack = false,
              Ship = true,
            },
            new EmployeeInfo()
            {
              Id = 4,
              Receive = false,
              Stow = false,
              Pick = true,
              Pack = false,
              Ship = true,
            },
          }); 
      #endregion
      #endregion


          base.Seed(context);
        } 
    }
}