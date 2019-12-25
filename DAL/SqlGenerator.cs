using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Data.Entity.Migrations.Sql;
using System.Data.SQLite.EF6.Migrations;

namespace SqliteEfTest.DAL
{
    internal class SqlGenerator : SQLiteMigrationSqlGenerator
    {
        public override IEnumerable<MigrationStatement> Generate(IEnumerable<MigrationOperation> migrationOperations, string providerManifestToken)
        {
            IEnumerable<MigrationStatement> result = base.Generate(migrationOperations, providerManifestToken);

            foreach (MigrationStatement statement in result)
            {
                if (statement.Sql.StartsWith("CREATE INDEX"))
                {
                    statement.Sql = "CREATE INDEX IF NOT EXISTS " + statement.Sql.Substring(12);
                }
                else if (statement.Sql.StartsWith("CREATE TABLE"))
                {
                    statement.Sql = "CREATE TABLE IF NOT EXISTS " + statement.Sql.Substring(12);
                }
            }
            return result;
        }
    }
}