using System.Web.Http;
using OrderServices.Data;
using Unity;
using Unity.WebApi;

namespace OrderServices
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            container.RegisterType<IDapperRepository, DapperRepository>();
            container.RegisterType<IClientRepository, ClientRepository>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}