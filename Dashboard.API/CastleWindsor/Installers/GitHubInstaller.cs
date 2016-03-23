// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OctokitInstaller.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the OctokitInstaller type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dashboard.API.CastleWindsor.Installers
{
    using Castle.MicroKernel.Registration;
    using Castle.MicroKernel.SubSystems.Configuration;
    using Castle.Windsor;

    using Octokit;

    /// <summary>
    /// The git hub installer.
    /// </summary>
    public class GitHubInstaller : IWindsorInstaller
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
                Component.For<GitHubClient>()
                    .DependsOn(Property.ForKey("ProductInformation").Eq(new ProductHeaderValue("dashboard"))));
        }
    }
}