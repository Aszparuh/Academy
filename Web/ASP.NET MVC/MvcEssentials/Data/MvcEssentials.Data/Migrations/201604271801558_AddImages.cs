namespace MvcEssentials.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddImages : DbMigration
    {
        public override void Up()
        {
            this.RenameTable(name: "dbo.Files", newName: "Images");
            this.DropForeignKey("dbo.Files", "Id", "dbo.NewsArticles");
            this.DropColumn("dbo.Images", "NewsArticleId");
            this.RenameColumn(table: "dbo.Images", name: "Id", newName: "NewsArticleId");
            this.RenameIndex(table: "dbo.Images", name: "IX_Id", newName: "IX_NewsArticleId");
            this.DropPrimaryKey("dbo.Images");
            this.AddColumn("dbo.NewsArticles", "ImageId", c => c.Int());
            this.AddColumn("dbo.Images", "Type", c => c.Int(nullable: false));
            this.AddColumn("dbo.Images", "NewsArticle_Id", c => c.Int());
            this.AlterColumn("dbo.Images", "Id", c => c.Int(nullable: false, identity: true));
            this.AddPrimaryKey("dbo.Images", "Id");
            this.CreateIndex("dbo.NewsArticles", "ImageId");
            this.CreateIndex("dbo.Images", "NewsArticle_Id");
            this.AddForeignKey("dbo.NewsArticles", "ImageId", "dbo.Images", "Id");
            this.AddForeignKey("dbo.Images", "NewsArticle_Id", "dbo.NewsArticles", "Id");
            this.AddForeignKey("dbo.Images", "NewsArticleId", "dbo.NewsArticles", "Id", cascadeDelete: true);
            this.DropColumn("dbo.NewsArticles", "FileId");
        }

        public override void Down()
        {
            this.AddColumn("dbo.NewsArticles", "FileId", c => c.Int());
            this.DropForeignKey("dbo.Images", "NewsArticleId", "dbo.NewsArticles");
            this.DropForeignKey("dbo.Images", "NewsArticle_Id", "dbo.NewsArticles");
            this.DropForeignKey("dbo.NewsArticles", "ImageId", "dbo.Images");
            this.DropIndex("dbo.Images", new[] { "NewsArticle_Id" });
            this.DropIndex("dbo.NewsArticles", new[] { "ImageId" });
            this.DropPrimaryKey("dbo.Images");
            this.AlterColumn("dbo.Images", "Id", c => c.Int(nullable: false));
            this.DropColumn("dbo.Images", "NewsArticle_Id");
            this.DropColumn("dbo.Images", "Type");
            this.DropColumn("dbo.NewsArticles", "ImageId");
            this.AddPrimaryKey("dbo.Images", "Id");
            this.RenameIndex(table: "dbo.Images", name: "IX_NewsArticleId", newName: "IX_Id");
            this.RenameColumn(table: "dbo.Images", name: "NewsArticleId", newName: "Id");
            this.AddColumn("dbo.Images", "NewsArticleId", c => c.Int(nullable: false));
            this.AddForeignKey("dbo.Files", "Id", "dbo.NewsArticles", "Id");
            this.RenameTable(name: "dbo.Images", newName: "Files");
        }
    }
}
