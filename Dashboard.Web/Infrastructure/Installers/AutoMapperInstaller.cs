// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AutoMapperInstaller.cs" company="">
//   
// </copyright>
// <summary>
//   The auto mapper installer.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dashboard.Web.Infrastructure.Installers
{
    using AutoMapper;

    using Castle.Core;
    using Castle.MicroKernel.Registration;
    using Castle.MicroKernel.SubSystems.Configuration;
    using Castle.Windsor;

    /// <summary>
    /// The auto mapper installer.
    /// </summary>
    public class AutoMapperInstaller : IWindsorInstaller
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
            Mapper.Initialize(x => x.ConstructServicesUsing(container.Resolve));

            RegisterProfilesAndResolvers(container);
            RegisterMapperEngine(container);
            RegisterInjectableMapper(container);
        }

        /// <summary>
        /// The register inject-able mapper.
        /// </summary>
        /// <param name="container">
        /// The container.
        /// </param>
        private static void RegisterInjectableMapper(IWindsorContainer container)
        {
            container
                .Register(
                    Classes
                        .FromAssemblyContaining<IMapper>()
                        .BasedOn<IMapper>()
                        .WithServiceAllInterfaces()
                        .LifestyleTransient());
        }

        /// <summary>
        /// The register mapper engine.
        /// </summary>
        /// <param name="container">
        /// The container.
        /// </param>
        private static void RegisterMapperEngine(IWindsorContainer container)
        {
            container
                .Register(
                    Component
                        .For<IMappingEngine>()
                        .Instance(Mapper.Engine));
        }

        /// <summary>
        /// The register profiles and resolvers.
        /// </summary>
        /// <param name="container">
        /// The container.
        /// </param>
        private static void RegisterProfilesAndResolvers(IWindsorContainer container)
        {
            container.Register(
                Types.FromAssemblyInThisApplication()
                    .BasedOn<Profile>()
                    .WithService.Base()
                    .Configure(c => c.Named(c.Implementation.FullName))
                    .LifestyleTransient());

            //// register value resolvers
            //container.Register(
            //    Classes
            //        .FromAssemblyContaining<IMapper>()
            //        .BasedOn<IValueResolver>()
            //        .LifestyleTransient());

            //container.Register(
            //    Classes
            //        .FromAssemblyContaining<IMapper>()
            //        .BasedOn(typeof(ITypeConverter<,>))
            //        .LifestyleTransient());

            //// register profiles
            //container.Register(
            //    Classes
            //        .FromAssemblyContaining<IMapper>()
            //        .BasedOn<Profile>()
            //        .WithServiceBase()
            //        .Configure(action => action.Properties(PropertyFilter.IgnoreAll))
            //        .LifestyleTransient());

            //container.Register(
            //    Classes
            //        .FromThisAssembly()
            //        .BasedOn<Profile>()
            //        .WithServiceBase()
            //        .Configure(action => action.Properties(PropertyFilter.IgnoreAll))
            //        .LifestyleTransient());

            var profiles = container.ResolveAll<Profile>();

            foreach (var profile in profiles)
            {
                Mapper.Initialize(cfg => { cfg.AddProfile(profile); });
            }

            container.Release(profiles);
        }
    }
}