using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Garage.Models
{

    public class GarageContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }

        public GarageContext() : base(nameOrConnectionString: "GarageContext") { }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.HasDefaultSchema("Garage");
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}