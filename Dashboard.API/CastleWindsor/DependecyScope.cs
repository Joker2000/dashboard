// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DependecyScope.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the DependencyScope type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dashboard.API.CastleWindsor
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Http.Dependencies;

    using Castle.MicroKernel;
    using Castle.MicroKernel.Lifestyle;

    /// <summary>
    /// The dependency scope.
    /// </summary>
    public class DependencyScope : IDependencyScope
    {
        /// <summary>
        /// The kernel.
        /// </summary>
        private readonly IKernel kernel;

        /// <summary>
        /// The disposable.
        /// </summary>
        private readonly IDisposable disposable;

        /// <summary>
        /// Initializes a new instance of the <see cref="DependencyScope"/> class.
        /// </summary>
        /// <param name="kernel">
        /// The kernel.
        /// </param>
        public DependencyScope(IKernel kernel)
        {
            this.kernel = kernel;
            this.disposable = kernel.BeginScope();
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
        /// The <see cref="IEnumerable{Object}"/>
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
            this.disposable.Dispose();
        }
    }
}