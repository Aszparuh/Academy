namespace Movies.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class StudiosMigration : DbMigration
    {
        public override void Up()
        {
            this.CreateTable(
                "dbo.Studios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudioName = c.String(nullable: false, maxLength: 200),
                        StudioAddress = c.String(nullable: false, maxLength: 500),
                        CreatedOn = c.DateTime(nullable: false),
                        ModifiedOn = c.DateTime(),
                        IsDeleted = c.Boolean(nullable: false),
                        DeletedOn = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.IsDeleted);

            this.AddColumn("dbo.Movies", "StudioId", c => c.Int(nullable: false));
            this.CreateIndex("dbo.Movies", "StudioId");
            this.AddForeignKey("dbo.Movies", "StudioId", "dbo.Studios", "Id", cascadeDelete: true);
            this.DropColumn("dbo.Movies", "StudioName");
            this.DropColumn("dbo.Movies", "StudioAddress");
        }

        public override void Down()
        {
            this.AddColumn("dbo.Movies", "StudioAddress", c => c.String(nullable: false, maxLength: 500));
            this.AddColumn("dbo.Movies", "StudioName", c => c.String(nullable: false, maxLength: 200));
            this.DropForeignKey("dbo.Movies", "StudioId", "dbo.Studios");
            this.DropIndex("dbo.Studios", new[] { "IsDeleted" });
            this.DropIndex("dbo.Movies", new[] { "StudioId" });
            this.DropColumn("dbo.Movies", "StudioId");
            this.DropTable("dbo.Studios");
        }
    }
}
