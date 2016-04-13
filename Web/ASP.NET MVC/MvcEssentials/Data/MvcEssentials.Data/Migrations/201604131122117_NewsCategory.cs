namespace MvcEssentials.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewsCategory : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.NewsArticles", name: "CategoryId", newName: "NewsCategoryId");
            RenameIndex(table: "dbo.NewsArticles", name: "IX_CategoryId", newName: "IX_NewsCategoryId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.NewsArticles", name: "IX_NewsCategoryId", newName: "IX_CategoryId");
            RenameColumn(table: "dbo.NewsArticles", name: "NewsCategoryId", newName: "CategoryId");
        }
    }
}
