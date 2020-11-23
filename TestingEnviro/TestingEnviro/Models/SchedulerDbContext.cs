using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TestingEnviro.Models
{
    public class SchedulerDbContext: DbContext
    {
        public SchedulerDbContext(): base("name=SchedulerDbContext")
        {

        }

        public DbSet<SchedulerEvent> SchedulerEvents { get; set; }
    }
}