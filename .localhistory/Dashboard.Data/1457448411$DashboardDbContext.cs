// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DashboardDbContext.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the DashboardDbContext type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dashboard.Data
{
    using System.Data.Entity;

    /// <summary>
    /// The dashboard db context.
    /// </summary>
    public class DashboardDbContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardDbContext"/> class.
        /// </summary>
        public DashboardDbContext()
            : base(nameOrConnectionString: "Dashboard")
        {
        }
    }
}
