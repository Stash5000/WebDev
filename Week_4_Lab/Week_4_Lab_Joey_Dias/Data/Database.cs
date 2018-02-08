using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Week_4_Lab_Joey_Dias.Data
{
    public class Database : DbContext
    {
        public Database() {
            Configuration.LazyLoadingEnabled = false;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            System.Data.Entity.Database.SetInitializer(new AppDbInitializer());
        }
        public static Entities.User outUser = null;

        public virtual DbSet<Entities.User> users { get; set; }
        public virtual DbSet<Entities.spaceship> ships { get; set; }
    }

    public class AppDbInitializer : DropCreateDatabaseIfModelChanges<Database>
    {
        // intentionally left blank
    }
}