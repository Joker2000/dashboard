﻿// --------------------------------------------------------------------------------------------------------------------
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
    using System.Data.Entity.ModelConfiguration.Conventions;

    using Dashboard.Data.Entities;

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

        /// <summary>
        /// Gets or sets the requirements.
        /// </summary>
        public DbSet<Requirement> Requirements { get; set; }

        /// <summary>
        /// Gets or sets the vehicle.
        /// </summary>
        public DbSet<Vehicle> Vehicle { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove< PluralizingTableNameConvention>();
        }
    }
}
