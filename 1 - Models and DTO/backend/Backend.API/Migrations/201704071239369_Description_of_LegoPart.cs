namespace Backend.API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Description_of_LegoPart : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LegoParts", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.LegoParts", "Description");
        }
    }
}
