// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Global.asax.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the WebApiApplication type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dashboard.API
{
    using System.Web.Http;
    using System.Web.Mvc;
    using System.Web.Optimization;
    using System.Web.Routing;

    using Castle.Windsor;
    using Castle.Windsor.Installer;

    /// <summary>
    /// The web api application.
    /// </summary>
    public class WebApiApplication : System.Web.HttpApplication
    {
        /// <summary>
        /// The application_ start.
        /// </summary>
        protected void Application_Start()
        {
            var container = new WindsorContainer();
            container.Install(FromAssembly.This());
            GlobalConfiguration.Configuration.DependencyResolver = new CastleWindsor.DependencyResolver(
                container.Kernel);

            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
