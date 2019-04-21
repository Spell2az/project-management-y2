using ApplicationCore;
using DAL;
using Microsoft.AspNet.Identity;
using System.Web.Mvc;
using ApplicationCore.Services;
using Unity;
using Unity.Injection;
using Unity.Lifetime;
using Unity.Mvc5;
using ApplicationCore.Domain;
using ClientEshop.Controllers;

namespace ClientEshop
{
    public class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            container.RegisterType<IProductService, ProductService>();
            container.RegisterType<IUnitOfWork, UnitOfWork>(new HierarchicalLifetimeManager());
            //container.RegisterType<IUserStore<IdentityUser, Guid>, UserStore>(new TransientLifetimeManager());
            //container.RegisterType<RoleStore>(new TransientLifetimeManager());
            container.RegisterType<AccountController>(new InjectionConstructor());
            
            container.RegisterType<ManageController>(new InjectionConstructor());
            

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}