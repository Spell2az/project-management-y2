using ApplicationCore;
using ApplicationCore.Services;
using DAL;
using System.Web.Http;
using System.Web.Mvc;
using Unity;
using Unity.Lifetime;


namespace StoreManagement
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers
            container.RegisterType<IProductService, ProductService>();
            container.RegisterType<IUnitOfWork, UnitOfWork>(new HierarchicalLifetimeManager());
            // e.g. container.RegisterType<ITestService, TestService>();
            DependencyResolver.SetResolver(new Unity.Mvc5.UnityDependencyResolver(container));

            GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container); ;
        }
    }
}