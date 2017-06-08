using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlatPlanet.Data.Models;

namespace FlatPlanet.Data
{
    public class ClickCounterContext: DbContext
    {
        public ClickCounterContext():base("ClickCounterContext")
        {
            
        }

        public DbSet<ClickCounter> ClickCounters { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
