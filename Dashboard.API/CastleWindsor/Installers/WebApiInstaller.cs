// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WebApiInstaller.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the WebApiInstaller type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dashboard.API.CastleWindsor.Installers
{
    using System.Web.Http;

    using Castle.MicroKernel.Registration;
    using Castle.MicroKernel.SubSystems.Configuration;
    using Castle.Windsor;

    /// <summary>
    /// The web api installer.
    /// </summary>
    public class WebApiInstaller : IWindsorInstaller
    {
        /// <summary>
        /// The install.
        /// </summary>
        /// <param name="container">
        /// The container.
        /// </param>
        /// <param name="store">
        /// The store.
        /// </param>
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Classes.FromThisAssembly().BasedOn<ApiController>().LifestyleScoped());
        }
    }
}