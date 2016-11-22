namespace FluentMigrator.Tests.Integration.Migrations.Tagged
{
    [Migration(6)]
    class TenantDTable : TenantDBaseMigration
    {
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