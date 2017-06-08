using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlatPlanet.Data.Models;

namespace FlatPlanet.Data
{
    public class ClickCounterInitializer: System.Data.Entity.DropCreateDatabaseIfModelChanges<ClickCounterContext>
    {
        protected override void Seed(ClickCounterContext context)
        {
            context.ClickCounters.Add(new ClickCounter{Counter = 0});

            context.SaveChanges();
        }

    }
}
