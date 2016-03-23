// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DalInstaller.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the DalInstaller type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dashboard.API.CastleWindsor.Installers
{
    using Castle.MicroKernel.Registration;
    using Castle.MicroKernel.SubSystems.Configuration;
    using Castle.Windsor;

    using Dashboard.API.DAL;

    /// <summary>
    /// The dal installer.
    /// </summary>
    public class DalInstaller : IWindsorInstaller
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
            container.Register(
                Component.For<IWebClient>().ImplementedBy<WebClient>().LifestyleTransient());
        }
    }
}