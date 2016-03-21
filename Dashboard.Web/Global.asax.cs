// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Global.asax.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the MvcApplication type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dashboard.Web
{
    using System.Web.Mvc;
    using System.Web.Optimization;
    using System.Web.Routing;

    using Castle.Windsor;
    using Castle.Windsor.Installer;

    using Dashboard.Web.Infrastructure;
    using Dashboard.Web.Mapping;

    /// <summary>
    /// The mvc application.
    /// </summary>
    public class MvcApplication : System.Web.HttpApplication
    {
        /// <summary>
        /// The container.
        /// </summary>
        private IWindsorContainer container;

        /// <summary>
        /// The application_ start.
        /// </summary>
        protected void Application_Start()
        {
            this.ConfigureWindsor();

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        /// <summary>
        /// The configure windsor.
        /// </summary>
        private void ConfigureWindsor()
        {
            this.container = new WindsorContainer();
            this.container.Install(FromAssembly.This());
            var castleControllerFactory = new CastleControllerFactory(this.container);
            ControllerBuilder.Current.SetControllerFactory(castleControllerFactory);
            AutoMapperServiceConfiguration.Configure();
        }
    }
}
