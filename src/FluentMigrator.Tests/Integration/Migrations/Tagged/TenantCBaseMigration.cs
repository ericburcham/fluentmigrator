namespace FluentMigrator.Tests.Integration.Migrations.Tagged
{
    [Tags(TagBehavior.Any, "TenantC")]
    public abstract class TenantCBaseMigration : Migration
    {
        protected const string TableName = "TenantCTable";
    }
}
