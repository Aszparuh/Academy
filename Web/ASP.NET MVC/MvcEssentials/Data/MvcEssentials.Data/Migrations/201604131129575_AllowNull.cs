namespace MvcEssentials.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AllowNull : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.NewsArticles", "NewsCategoryId", "dbo.NewsCategories");
            DropForeignKey("dbo.NewsArticles", "RegionId", "dbo.Regions");
            DropIndex("dbo.NewsArticles", new[] { "NewsCategoryId" });
            DropIndex("dbo.NewsArticles", new[] { "RegionId" });
            AlterColumn("dbo.NewsArticles", "NewsCategoryId", c => c.Int());
            AlterColumn("dbo.NewsArticles", "RegionId", c => c.Int());
            CreateIndex("dbo.NewsArticles", "NewsCategoryId");
            CreateIndex("dbo.NewsArticles", "RegionId");
            AddForeignKey("dbo.NewsArticles", "NewsCategoryId", "dbo.NewsCategories", "Id");
            AddForeignKey("dbo.NewsArticles", "RegionId", "dbo.Regions", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NewsArticles", "RegionId", "dbo.Regions");
            DropForeignKey("dbo.NewsArticles", "NewsCategoryId", "dbo.NewsCategories");
            DropIndex("dbo.NewsArticles", new[] { "RegionId" });
            DropIndex("dbo.NewsArticles", new[] { "NewsCategoryId" });
            AlterColumn("dbo.NewsArticles", "RegionId", c => c.Int(nullable: false));
            AlterColumn("dbo.NewsArticles", "NewsCategoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.NewsArticles", "RegionId");
            CreateIndex("dbo.NewsArticles", "NewsCategoryId");
            AddForeignKey("dbo.NewsArticles", "RegionId", "dbo.Regions", "Id", cascadeDelete: true);
            AddForeignKey("dbo.NewsArticles", "NewsCategoryId", "dbo.NewsCategories", "Id", cascadeDelete: true);
        }
    }
}
