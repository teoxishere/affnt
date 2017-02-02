namespace affnt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedFlagToPerson : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "Approval", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "Approval");
        }
    }
}
