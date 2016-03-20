// --------------------------------------------------------------------------------------------------------------------
// <copyright file="VehicleProfile.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the VehicleProfile type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dashboard.Web.Mapping
{
    using AutoMapper;

    using Dashboard.Dto;
    using Dashboard.Web.ViewModels;

    /// <summary>
    /// The vehicle profile.
    /// </summary>
    public class VehicleProfile : Profile
    {
        /// <summary>
        /// The configure.
        /// </summary>
        protected override void Configure()
        {
            this.CreateMap<VehicleDto, DvlaWidgetViewModel>();
            this.CreateMap<RequirementDto, RequirementViewModel>();
        }
    }
}