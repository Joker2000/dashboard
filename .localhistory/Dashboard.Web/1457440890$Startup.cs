﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Startup.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the Startup type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Dashboard.Web.Startup))]

namespace Dashboard.Web
{
    /// <summary>
    /// The startup.
    /// </summary>
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
