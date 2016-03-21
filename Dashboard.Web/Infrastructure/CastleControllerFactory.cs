// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CastleControllerFactory.cs" company="">
//   
// </copyright>
// <summary>
//   The castle controller factory.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dashboard.Web.Infrastructure
{
    using System;
    using System.Web.Mvc;
    using System.Web.Routing;

    using Castle.Windsor;

    /// <summary>
    /// The castle controller factory.
    /// </summary>
    public class CastleControllerFactory : DefaultControllerFactory
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CastleControllerFactory"/> class.
        /// </summary>
        /// <param name="container">
        /// The container.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// The argument is null.
        /// </exception>
        public CastleControllerFactory(IWindsorContainer container)
        {
            if (container == null)
            {
                throw new ArgumentNullException(nameof(container));
            }

            this.Container = container;
        }

        /// <summary>
        /// Gets or sets the container.
        /// </summary>
        public IWindsorContainer Container { get; protected set; }

        /// <summary>
        /// Releases the specified controller.
        /// </summary>
        /// <param name="controller">The controller to release.</param>
        public override void ReleaseController(IController controller)
        {
            // If controller implements IDisposable, clean it up responsibly
            var disposableController = controller as IDisposable;
            disposableController?.Dispose();

            // Inform Castle that the controller is no longer required
            this.Container.Release(controller);
        }

        /// <summary>
        /// Retrieves the controller instance for the specified request context and controller type.
        /// </summary>
        /// <param name="requestContext">
        /// The context of the HTTP request, which includes the HTTP context and route data.
        /// </param>
        /// <param name="controllerType">
        /// The controller Type.
        /// </param>
        /// controllerType"&gt;The type of the controller.
        /// <returns>
        /// The controller instance.
        /// </returns>>
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            if (controllerType == null)
            {
                return null;
            }

            // Retrieve the requested controller from Castle
            return this.Container.Resolve(controllerType) as IController;
        }
    }
}