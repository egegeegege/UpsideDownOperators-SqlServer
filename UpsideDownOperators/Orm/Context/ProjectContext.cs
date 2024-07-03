using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpsideDownOperators.Orm.Entity;

namespace UpsideDownOperators.Orm.Context
{
    public class ProjectContext : DbContext
    {
        public ProjectContext()
        {
            Database.Connection.ConnectionString = "Server=.;Database=UpsideDownOperators;uid=sa;pwd=1453";
        }
        // Migration steps
        // enable-migrations
        // add-migration 'a'
        // update-database
        public DbSet<UserProperty> UserProperties { get; set; }
        public DbSet<ExecutiveProperty> ExecutiveProperties { get; set; }
    }
}
