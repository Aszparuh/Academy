namespace MvcEssentials.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddRelations : DbMigration
    {
        public override void Up()
        {
            this.AddColumn("dbo.NewsArticles", "Title", c => c.String(nullable: false, maxLength: 300));
        }

        public override void Down()
        {
            this.DropColumn("dbo.NewsArticles", "Title");
        }
    }
}
