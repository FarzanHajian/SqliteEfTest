using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using SqliteEfTest.Model;

namespace SqliteEfTest.DAL
{
    internal class MainContext : DbContext
    {
        public DbSet<Industry> Industries { get; set; }

        public MainContext() : base("main")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}