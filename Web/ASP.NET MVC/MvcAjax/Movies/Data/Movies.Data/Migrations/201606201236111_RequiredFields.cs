namespace Movies.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class RequiredFields : DbMigration
    {
        public override void Up()
        {
            this.AlterColumn("dbo.Movies", "Title", c => c.String(nullable: false, maxLength: 200));
            this.AlterColumn("dbo.Movies", "StudioName", c => c.String(nullable: false, maxLength: 200));
            this.AlterColumn("dbo.Movies", "StudioAddress", c => c.String(nullable: false, maxLength: 500));
            this.AlterColumn("dbo.Movies", "MovieDesciption", c => c.String(nullable: false, maxLength: 2000));
        }

        public override void Down()
        {
            this.AlterColumn("dbo.Movies", "MovieDesciption", c => c.String(maxLength: 2000));
            this.AlterColumn("dbo.Movies", "StudioAddress", c => c.String());
            this.AlterColumn("dbo.Movies", "StudioName", c => c.String());
            this.AlterColumn("dbo.Movies", "Title", c => c.String(maxLength: 200));
        }
    }
}
