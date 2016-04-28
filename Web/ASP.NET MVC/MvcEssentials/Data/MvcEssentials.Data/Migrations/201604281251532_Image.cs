namespace MvcEssentials.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class Image : DbMigration
    {
        public override void Up()
        {
            this.DropForeignKey("dbo.NewsArticles", "ImageId", "dbo.Images");
            this.DropForeignKey("dbo.Images", "NewsArticle_Id", "dbo.NewsArticles");
            this.DropIndex("dbo.NewsArticles", new[] { "ImageId" });
            this.DropIndex("dbo.Images", new[] { "NewsArticleId" });
            this.DropIndex("dbo.Images", new[] { "NewsArticle_Id" });
            this.DropColumn("dbo.Images", "NewsArticleId");
            this.RenameColumn(table: "dbo.Images", name: "NewsArticle_Id", newName: "NewsArticleId");
            this.AlterColumn("dbo.Images", "NewsArticleId", c => c.Int(nullable: false));
            this.CreateIndex("dbo.Images", "NewsArticleId");
            this.AddForeignKey("dbo.Images", "NewsArticleId", "dbo.NewsArticles", "Id", cascadeDelete: true);
            this.DropColumn("dbo.NewsArticles", "ImageId");
        }

        public override void Down()
        {
            this.AddColumn("dbo.NewsArticles", "ImageId", c => c.Int());
            this.DropForeignKey("dbo.Images", "NewsArticleId", "dbo.NewsArticles");
            this.DropIndex("dbo.Images", new[] { "NewsArticleId" });
            this.AlterColumn("dbo.Images", "NewsArticleId", c => c.Int());
            this.RenameColumn(table: "dbo.Images", name: "NewsArticleId", newName: "NewsArticle_Id");
            this.AddColumn("dbo.Images", "NewsArticleId", c => c.Int(nullable: false));
            this.CreateIndex("dbo.Images", "NewsArticle_Id");
            this.CreateIndex("dbo.Images", "NewsArticleId");
            this.CreateIndex("dbo.NewsArticles", "ImageId");
            this.AddForeignKey("dbo.Images", "NewsArticle_Id", "dbo.NewsArticles", "Id");
            this.AddForeignKey("dbo.NewsArticles", "ImageId", "dbo.Images", "Id");
        }
    }
}
