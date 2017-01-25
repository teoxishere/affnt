namespace affnt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class requiredLook : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.People", "LookingFor", c => c.String(nullable: false, maxLength: 1));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "LookingFor", c => c.String(maxLength: 1));
        }
    }
}
