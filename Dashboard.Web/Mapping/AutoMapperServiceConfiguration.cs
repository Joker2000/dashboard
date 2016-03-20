// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AutoMapperServiceConfiguration.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the AutoMapperServiceConfiguration type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dashboard.Web.Mapping
{
    using AutoMapper;

    /// <summary>
    /// The auto Mapper service configuration.
    /// </summary>
    public class AutoMapperServiceConfiguration
    {
        /// <summary>
        /// Gets the mapper.
        /// </summary>
        public static IMapper Mapper { get; private set; }

        /// <summary>
        /// The configure.
        /// </summary>
        public static void Configure()
        {
            var config = new MapperConfiguration(cfg => { cfg.AddProfile<VehicleProfile>(); });
            Mapper = config.CreateMapper();
        }
    }
}