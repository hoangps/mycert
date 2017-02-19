namespace MyCert.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDB_20170220 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tests", "Price", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tests", "Price");
        }
    }
}
