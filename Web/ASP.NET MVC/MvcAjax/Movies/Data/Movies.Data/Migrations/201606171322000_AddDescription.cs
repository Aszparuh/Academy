namespace Movies.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddDescription : DbMigration
    {
        public override void Up()
        {
            this.AddColumn("dbo.Movies", "MovieDesciption", c => c.String(maxLength: 2000));
            this.DropColumn("dbo.Movies", "MovieDescibtion");
        }

        public override void Down()
        {
            this.AddColumn("dbo.Movies", "MovieDescibtion", c => c.String(maxLength: 2000));
            this.DropColumn("dbo.Movies", "MovieDesciption");
        }
    }
}
