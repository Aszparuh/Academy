namespace Movies.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddGender : DbMigration
    {
        public override void Up()
        {
            this.AddColumn("dbo.Actors", "Gender", c => c.Int(nullable: false));
        }

        public override void Down()
        {
            this.DropColumn("dbo.Actors", "Gender");
        }
    }
}
