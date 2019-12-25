using System.Configuration;
using System.Data.Entity;
using System.IO;
using SqliteEfTest.Migrations;

namespace SqliteEfTest.DAL
{
    internal static class Helper
    {
        public static void Initialize()
        {
            string fileName = ConfigurationManager.ConnectionStrings["main"].ConnectionString.Split('=')[1];
            if (!File.Exists(fileName)) File.Create(fileName);

            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MainContext, Migrations.Configuration>());
        }
    }
}