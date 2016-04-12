namespace MvcEssentials.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddConnection : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NewsArticles", "ApplicationUserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.NewsArticles", "ApplicationUserId");
            AddForeignKey("dbo.NewsArticles", "ApplicationUserId", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NewsArticles", "ApplicationUserId", "dbo.AspNetUsers");
            DropIndex("dbo.NewsArticles", new[] { "ApplicationUserId" });
            DropColumn("dbo.NewsArticles", "ApplicationUserId");
        }
    }
}
