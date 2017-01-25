namespace affnt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1st : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "Email", c => c.String());
            AddColumn("dbo.People", "Password", c => c.String(maxLength: 100));
            AddColumn("dbo.People", "ConfirmPassword", c => c.String());
            AddColumn("dbo.People", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.People", "ApplicationUser_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.People", "ApplicationUser_Id");
            AddForeignKey("dbo.People", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.People", new[] { "ApplicationUser_Id" });
            DropColumn("dbo.People", "ApplicationUser_Id");
            DropColumn("dbo.People", "Discriminator");
            DropColumn("dbo.People", "ConfirmPassword");
            DropColumn("dbo.People", "Password");
            DropColumn("dbo.People", "Email");
        }
    }
}
