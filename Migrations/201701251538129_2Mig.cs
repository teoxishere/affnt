namespace affnt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2Mig : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "Person_Id", c => c.Int());
            AlterColumn("dbo.People", "LookingFor", c => c.String(maxLength: 1));
            CreateIndex("dbo.People", "Person_Id");
            AddForeignKey("dbo.People", "Person_Id", "dbo.People", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "Person_Id", "dbo.People");
            DropIndex("dbo.People", new[] { "Person_Id" });
            AlterColumn("dbo.People", "LookingFor", c => c.String(nullable: false, maxLength: 1));
            DropColumn("dbo.People", "Person_Id");
        }
    }
}
