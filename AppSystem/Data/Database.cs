using AppSystem.Maps;
using AppSystem.Models;
using System.Data.Entity;

namespace AppSystem.Data
{
    public class Database : DbContext
    {
        public Database(string nameOrConnectionString)
            :base(nameOrConnectionString)
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Uf> Uf { get; set; }
        public DbSet<City> City { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UfMap());
            modelBuilder.Configurations.Add(new CityMap());
        }
    }
}
