namespace FluentMigrator.Tests.Integration.Migrations.Tagged
{
    [Tags("TenantC", "TenantD")]
    [Migration(7)]
    public class TenantCandDTable : Migration
    {
        private const string TableName = "TenantCandDTable";

        public override void Up()
        {
            Create.Table(TableName)
                .WithColumn("Id").AsInt32();
        }

        public override void Down()
        {
            Delete.Table(TableName);
        }
    }
}