// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ServiceInstaller.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the ServiceInstaller type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dashboard.Web.Infrastructure.Installers
{
    using Castle.MicroKernel.Registration;
    using Castle.MicroKernel.SubSystems.Configuration;
    using Castle.Windsor;

    using Dashboard.Web.Services;

    /// <summary>
    /// The service installer.
    /// </summary>
    public class ServiceInstaller : IWindsorInstaller
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
            container.Register(Component.For<IDvlaService>().ImplementedBy<DvlaService>().LifestyleTransient());
        }
    }
}