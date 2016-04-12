// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DependencyResolver.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the DependencyResolver type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dashboard.API.CastleWindsor
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Http.Dependencies;

    using Castle.MicroKernel;

    /// <summary>
    /// The dependency resolver.
    /// </summary>
    internal class DependencyResolver : System.Web.Http.Dependencies.IDependencyResolver
    {
        /// <summary>
        /// The kernel.
        /// </summary>
        private readonly IKernel kernel;

        /// <summary>
        /// Initializes a new instance of the <see cref="DependencyResolver"/> class.
        /// </summary>
        /// <param name="kernel">
        /// The kernel.
        /// </param>
        public DependencyResolver(IKernel kernel)
        {
            this.kernel = kernel;
        }

        /// <summary>
        /// The begin scope.
        /// </summary>
        /// <returns>
        /// The <see cref="IDependencyScope"/>.
        /// </returns>
        public IDependencyScope BeginScope()
        {
            return new DependencyScope(this.kernel);
        }

        /// <summary>
        /// The get service.
        /// </summary>
        /// <param name="type">
        /// The type.
        /// </param>
        /// <returns>
        /// The <see cref="object"/>.
        /// </returns>
        public object GetService(Type type)
        {
            return this.kernel.HasComponent(type) ? this.kernel.Resolve(type) : null;
        }

        /// <summary>
        /// The get services.
        /// </summary>
        /// <param name="type">
        /// The type.
        /// </param>
        /// <returns>
        /// The <see cref="IEnumerable{Object}"/>.
        /// </returns>
        public IEnumerable<object> GetServices(Type type)
        {
            return this.kernel.ResolveAll(type).Cast<object>();
        }

        /// <summary>
        /// The dispose.
        /// </summary>
        public void Dispose()
        {
        }
    }
}