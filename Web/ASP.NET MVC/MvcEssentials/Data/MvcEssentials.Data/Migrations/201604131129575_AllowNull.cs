namespace MvcEssentials.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AllowNull : DbMigration
    {
        public override void Up()
        {
            this.DropForeignKey("dbo.NewsArticles", "NewsCategoryId", "dbo.NewsCategories");
            this.DropForeignKey("dbo.NewsArticles", "RegionId", "dbo.Regions");
            this.DropIndex("dbo.NewsArticles", new[] { "NewsCategoryId" });
            this.DropIndex("dbo.NewsArticles", new[] { "RegionId" });
            this.AlterColumn("dbo.NewsArticles", "NewsCategoryId", c => c.Int());
            this.AlterColumn("dbo.NewsArticles", "RegionId", c => c.Int());
            this.CreateIndex("dbo.NewsArticles", "NewsCategoryId");
            this.CreateIndex("dbo.NewsArticles", "RegionId");
            this.AddForeignKey("dbo.NewsArticles", "NewsCategoryId", "dbo.NewsCategories", "Id");
            this.AddForeignKey("dbo.NewsArticles", "RegionId", "dbo.Regions", "Id");
        }

        public override void Down()
        {
            this.DropForeignKey("dbo.NewsArticles", "RegionId", "dbo.Regions");
            this.DropForeignKey("dbo.NewsArticles", "NewsCategoryId", "dbo.NewsCategories");
            this.DropIndex("dbo.NewsArticles", new[] { "RegionId" });
            this.DropIndex("dbo.NewsArticles", new[] { "NewsCategoryId" });
            this.AlterColumn("dbo.NewsArticles", "RegionId", c => c.Int(nullable: false));
            this.AlterColumn("dbo.NewsArticles", "NewsCategoryId", c => c.Int(nullable: false));
            this.CreateIndex("dbo.NewsArticles", "RegionId");
            this.CreateIndex("dbo.NewsArticles", "NewsCategoryId");
            this.AddForeignKey("dbo.NewsArticles", "RegionId", "dbo.Regions", "Id", cascadeDelete: true);
            this.AddForeignKey("dbo.NewsArticles", "NewsCategoryId", "dbo.NewsCategories", "Id", cascadeDelete: true);
        }
    }
}
