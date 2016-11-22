namespace FluentMigrator.Tests.Integration.Migrations.Tagged
{
    [Tags(TagBehavior.Any, "TenantD")]
    public abstract class TenantDBaseMigration : Migration
    {
        protected const string TableName = "TenantDTable";
    }
}