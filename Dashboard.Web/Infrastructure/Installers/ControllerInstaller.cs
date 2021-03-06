﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ControllerInstaller.cs" company="">
//   
// </copyright>
// <summary>
//   The controller installer.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dashboard.Web.Infrastructure.Installers
{
    using System.Web.Mvc;

    using Castle.MicroKernel.Registration;
    using Castle.MicroKernel.SubSystems.Configuration;
    using Castle.Windsor;

    /// <summary>
    /// The controller installer.
    /// </summary>
    public class ControllerInstaller : IWindsorInstaller
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
            container.Register(Classes.FromThisAssembly().BasedOn<Controller>().LifestyleTransient());
        }
    }
}