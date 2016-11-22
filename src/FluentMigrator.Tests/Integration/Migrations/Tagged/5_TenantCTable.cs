namespace FluentMigrator.Tests.Integration.Migrations.Tagged
{
    [Migration(5)]
    class TenantCTable : TenantCBaseMigration
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