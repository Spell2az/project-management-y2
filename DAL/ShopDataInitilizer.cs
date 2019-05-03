using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Domain;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DAL
{
    public class ShopDataInitialiser : DropCreateDatabaseAlways<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            #region UserRoles

            const string adminRoleName = "Admin";
            const string customerRoleName = "Customer";
            const string employeeRoleName = "Employee";

            var roleStore = new RoleStore<IdentityRole>(context);
            var roleManager = new RoleManager<IdentityRole>(roleStore);

            var adminRole = new IdentityRole { Name = adminRoleName };
            var userRole = new IdentityRole { Name = customerRoleName };
            var employeeRole = new IdentityRole { Name = employeeRoleName };

            roleManager.Create(adminRole);
            roleManager.Create(userRole);
            roleManager.Create(employeeRole);


            #endregion

            var userStore = new UserStore<ApplicationUser>(context);
            var userManager = new UserManager<ApplicationUser>(userStore);


            var testUser = new ApplicationUser()
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "test@gmail.com",
                Email = "test@gmail.com",
            };

            userManager.Create(testUser, "Pass@word1");
            userManager.AddToRole(testUser.Id, customerRoleName);


            #region Users - Admin


            var admin = new ApplicationUser()
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "admin@gmail.com",
                Email = "amdin@gmail.com",

            };

            userManager.Create(admin, "Pass@word1");
            userManager.AddToRole(admin.Id, adminRoleName);

            #endregion



            #region Users - Employees


            #region Employee info

            var EmployeeInfos = new EmployeeInfo[] {
                new EmployeeInfo()
                {
                    Receive = true,
                    Stow = true,
                    Pick = false,
                    Pack = false,
                    Ship = false,
                },
                new EmployeeInfo()
                {
                    Receive = false,
                    Stow = false,
                    Pick = false,
                    Pack = false,
                    Ship = true,
                },
                new EmployeeInfo()
                {
                    Receive = false,
                    Stow = false,
                    Pick = true,
                    Pack = false,
                    Ship = true,
                },
                new EmployeeInfo()
                {
                    Receive = false,
                    Stow = false,
                    Pick = true,
                    Pack = false,
                    Ship = true,
                },
                new EmployeeInfo()
                {
                    Receive = true,
                    Stow = false,
                    Pick = true,
                    Pack = false,
                    Ship = true,
                }
            };
            #endregion

            foreach (var n in Enumerable.Range(0, 5))
            {
                var employee = new ApplicationUser()
                {
                    Id = Guid.NewGuid().ToString(),
                    UserName = $"employee{n}@gmail.com",
                    Email = $"employee{n}@gmail.com",
                    EmployeeInfo = EmployeeInfos[n]
                };



                userManager.Create(employee, "Pass@word1");
                userManager.AddToRole(employee.Id, employeeRoleName);
            }


            #endregion

            #region Products
            context.Products.AddRange(new Product[]
               {
        new Product()
        {
          Name = "Hard Cover Carrying Case for AKG N60NC",
          Category = Categories.Accessories,
          Description = "Dolores ut eligendi. Corrupti voluptatem voluptatem magnam quis odit. Eos molestias modi et voluptas aut. Consequatur qui illo voluptatem odio. Tempora est ratione vel itaque. Sed et quaerat aut itaque aut vitae sit debitis.\n\nDeserunt vel hic totam ea. Et aut omnis. Mollitia amet perspiciatis ipsa accusamus quibusdam odio velit et. Suscipit ipsam ducimus. Fugiat aut sed veniam repellat dolore eum.\n\nQuae laudantium rerum corrupti repellendus. Mollitia vitae non neque sit earum laudantium quo recusandae. Consequatur facilis voluptatibus. Sint perferendis minima.",
          Image = "https://picsum.photos/100/100/?image=413",
          Price= 10.99m,
        },
        new Product()
        {
          Name = "King Universal Freestanding Speaker Floor Stand, Pair, Black for Surround Sound Speakers",
          Category = Categories.Accessories,
          Description= "Repellat est a. Et odio doloribus quia consequatur laudantium. Laudantium magnam voluptas aut exercitationem beatae. Sed cum sit adipisci eaque et quam aut quidem suscipit. Soluta dolores repudiandae provident dignissimos. Ea libero et nemo incidunt reprehenderit officia et.\n\nSit adipisci ex et inventore. Omnis eligendi quis asperiores et est corporis perferendis cupiditate et. Consequatur magni voluptas natus non consequatur animi ea.\n\nFacilis ut quis et. Doloremque consequatur ut voluptates veniam. Quaerat nobis ea modi dolore ducimus. Autem commodi et dolor et id qui omnis cum quisquam. Iure facere et iusto voluptas.",
          Image= "https://picsum.photos/100/100/?image=781",
          Price= 32.00m,
        },
        new Product()
        {
          Name = "AKG N60NC Foldable Active Noise Cancelling On-Ear Headphones",
          Category = Categories.Headphones,
          Description = "Nisi officiis et ut nesciunt deserunt porro tempora maxime molestiae. Nobis incidunt voluptatem. Corporis assumenda qui. Vitae odio quibusdam. Qui minus incidunt voluptas sint quia.",
          Image = "https://picsum.photos/100/100/?image=965",
          Price= 110.99m,
        },
        new Product()
        {
          Name = "Sennheiser PXC 550 Wireless",
          Category = Categories.Headphones,
          Description= "Et occaecati modi maxime dignissimos ut suscipit nobis ea. Est quaerat magnam et ut unde nulla sint. Facilis voluptatibus occaecati provident non. Voluptas incidunt quas dolore rerum esse numquam molestiae consequuntur. Repudiandae sint quo sit. Eum similique doloremque beatae saepe quia deserunt ut.\n\nPorro asperiores modi nostrum autem explicabo. Nostrum et id quod fugiat iusto rem quaerat reprehenderit eum. Optio et aperiam.",
          Image = "https://picsum.photos/100/100/?image=199",
          Price= 224.99m,
        },
        new Product()
        {
          Name = "Bowers & Wilkins PX Bluetooth Wireless Headphones",
          Category = Categories.Headphones,
          Description = "Nisi officiis et ut nesciunt deserunt porro tempora maxime molestiae. Nobis incidunt voluptatem. Corporis assumenda qui. Vitae odio quibusdam. Qui minus incidunt voluptas sint quia.",
          Image = "https://picsum.photos/100/100/?image=965",
          Price= 329.00m,
        },
        new Product()
        {
          Name = "Logitech Z906 Stereo Speakers 3D 5.1 Dolby Surround Sound, THX, 1000 W",
          Category = Categories.Speakers,
          Description =  "Vitae eligendi quo maiores minima eum soluta perspiciatis. Doloremque culpa fugiat. Rerum culpa quod minus enim at ratione. Laborum quis consequatur quibusdam ut non ea. Ipsa sequi optio nemo explicabo et ratione aut. A at in.\n\nMaiores voluptatum et officia iste et quis repudiandae aut laborum. Quasi rem ea ut amet non vero voluptatem. Quasi debitis rerum cupiditate quas nostrum iusto minus qui enim. Similique error est corporis necessitatibus commodi possimus ut dolores quaerat. Ab dicta distinctio accusantium. Quod nam illum accusantium.",
          Image = "https://picsum.photos/100/100/?image=280",
          Price= 235.99m,
        },
        new Product()
        {
          Name = "Bose Soundbar 700 (Alexa Built) In with Bass Module 500 and Surround Speakers Bundle",
          Category = Categories.Speakers,
          Description = "Soluta earum nulla animi fuga ex eveniet quia. Libero saepe quisquam. Sunt vel minus aliquam at incidunt maiores qui fugiat nesciunt.\n\nOdio beatae corrupti nam temporibus nobis distinctio et et. Blanditiis non dolor. Aliquam sint repellendus vero et dolores dolore cum aut. Enim et qui maxime fugit et pariatur repellendus provident.\n\nAd velit distinctio nemo. Ut quis ipsam voluptatum molestiae aut rem voluptatem aut rem. Aut ex vel mollitia omnis ad cum aliquid unde. Repudiandae voluptatem officia magnam tempore. Accusantium est reiciendis aut consequuntur omnis. Voluptatem sapiente ea voluptas rerum molestias assumenda autem assumenda.",
          Image = "https://picsum.photos/100/100/?image=287",
          Price= 1_423.39m,
        },
        new Product()
        {
          Name = "Sony SA-Z9R Wireless Rear Speakers",
          Category = Categories.Speakers,
          Description = "Id nemo omnis. Voluptatem ut qui tempora aliquam voluptate dignissimos quis. Consequatur tempore nihil ut omnis harum in rerum temporibus nulla. Repudiandae ratione tempore quia autem et cum accusamus tempora.",
          Image = "https://picsum.photos/100/100/?image=399",
          Price= 269.99m,
        },
               });
            #endregion


            #region WarehouseLocations

            // 5 aisles with 10 locations each
            var warehouseLocations = Enumerable.Range(1, 5)
                .Select(a => Enumerable.Range(1, 10)
                .Select(l =>
                    new WarehouseLocation()
                    {
                        Id = $"A-0{a}0-{l.ToString().PadLeft(3, '0')}"
                    }))
                .SelectMany(x => x);
            context.WarehouseLocations.AddRange(warehouseLocations);
            #endregion

            base.Seed(context);
        }
    }
}
