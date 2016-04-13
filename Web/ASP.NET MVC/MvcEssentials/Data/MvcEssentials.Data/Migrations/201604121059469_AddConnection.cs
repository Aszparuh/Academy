namespace MvcEssentials.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddConnection : DbMigration
    {
        public override void Up()
        {
            this.AddColumn("dbo.NewsArticles", "ApplicationUserId", c => c.String(maxLength: 128));
            this.CreateIndex("dbo.NewsArticles", "ApplicationUserId");
            this.AddForeignKey("dbo.NewsArticles", "ApplicationUserId", "dbo.AspNetUsers", "Id");
        }

        public override void Down()
        {
            this.DropForeignKey("dbo.NewsArticles", "ApplicationUserId", "dbo.AspNetUsers");
            this.DropIndex("dbo.NewsArticles", new[] { "ApplicationUserId" });
            this.DropColumn("dbo.NewsArticles", "ApplicationUserId");
        }
    }
}
