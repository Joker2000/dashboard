// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ServicesInstaller.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the ServicesInstaller type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dashboard.API.CastleWindsor.Installers
{
    using Castle.MicroKernel.Registration;
    using Castle.MicroKernel.SubSystems.Configuration;
    using Castle.Windsor;

    using Dashboard.API.Services.Parsers;
    using Dashboard.API.Services.Services;

    /// <summary>
    /// The services installer.
    /// </summary>
    public class ServicesInstaller : IWindsorInstaller
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
            container.Register(Component.For<IGitHubService>().ImplementedBy<GitHubService>().LifestyleTransient())
                .Register(Component.For<IVehicleService>().ImplementedBy<VehicleService>().LifestyleTransient())
                .Register(Component.For<IHtmlParser>().ImplementedBy<VehicleHtmlParser>().LifestyleTransient());
        }
    }
}