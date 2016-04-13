namespace MvcEssentials.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class NewsCategory : DbMigration
    {
        public override void Up()
        {
            this.RenameColumn(table: "dbo.NewsArticles", name: "CategoryId", newName: "NewsCategoryId");
            this.RenameIndex(table: "dbo.NewsArticles", name: "IX_CategoryId", newName: "IX_NewsCategoryId");
        }

        public override void Down()
        {
            this.RenameIndex(table: "dbo.NewsArticles", name: "IX_NewsCategoryId", newName: "IX_CategoryId");
            this.RenameColumn(table: "dbo.NewsArticles", name: "NewsCategoryId", newName: "CategoryId");
        }
    }
}
