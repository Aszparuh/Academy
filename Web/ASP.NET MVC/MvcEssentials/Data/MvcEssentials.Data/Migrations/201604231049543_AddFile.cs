namespace MvcEssentials.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddFile : DbMigration
    {
        public override void Up()
        {
            this.CreateTable(
                "dbo.Files",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        FileName = c.String(maxLength: 255),
                        ContentType = c.String(maxLength: 100),
                        Content = c.Binary(),
                        NewsArticleId = c.Int(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        ModifiedOn = c.DateTime(),
                        IsDeleted = c.Boolean(nullable: false),
                        DeletedOn = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.NewsArticles", t => t.Id)
                .Index(t => t.Id)
                .Index(t => t.IsDeleted);

            this.AddColumn("dbo.NewsArticles", "FileId", c => c.Int());
        }

        public override void Down()
        {
            this.DropForeignKey("dbo.Files", "Id", "dbo.NewsArticles");
            this.DropIndex("dbo.Files", new[] { "IsDeleted" });
            this.DropIndex("dbo.Files", new[] { "Id" });
            this.DropColumn("dbo.NewsArticles", "FileId");
            this.DropTable("dbo.Files");
        }
    }
}
