namespace SqliteEfTest.Migrations
{
    using System.Data.Entity.Migrations;
    using SqliteEfTest.DAL;

    internal sealed class Configuration : DbMigrationsConfiguration<SqliteEfTest.DAL.MainContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            SetSqlGenerator("System.Data.SQLite", new SqlGenerator());
        }

        protected override void Seed(SqliteEfTest.DAL.MainContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}