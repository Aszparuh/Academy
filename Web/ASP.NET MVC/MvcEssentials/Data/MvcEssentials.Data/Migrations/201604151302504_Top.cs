namespace MvcEssentials.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class Top : DbMigration
    {
        public override void Up()
        {
            this.AddColumn("dbo.NewsArticles", "IsTop", c => c.Boolean());
        }

        public override void Down()
        {
            this.DropColumn("dbo.NewsArticles", "IsTop");
        }
    }
}
