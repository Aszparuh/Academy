namespace Movies.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddsDescribtion : DbMigration
    {
        public override void Up()
        {
            this.AddColumn("dbo.Movies", "MovieDescibtion", c => c.String(maxLength: 2000));
        }

        public override void Down()
        {
            this.DropColumn("dbo.Movies", "MovieDescibtion");
        }
    }
}
