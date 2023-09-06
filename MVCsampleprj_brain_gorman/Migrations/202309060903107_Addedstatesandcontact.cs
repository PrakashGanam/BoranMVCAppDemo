namespace MVCsampleprj_brain_gorman.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addedstatesandcontact : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 250),
                        PhonePrimary = c.String(nullable: false, maxLength: 15),
                        PhoneSecondary = c.String(maxLength: 15),
                        BirthDay = c.DateTime(nullable: false),
                        StreetAddress1 = c.String(nullable: false, maxLength: 150),
                        StreetAddress2 = c.String(),
                        City = c.String(nullable: false, maxLength: 25),
                        Stateid = c.Int(nullable: false),
                        Zip = c.String(maxLength: 10),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.States", t => t.Stateid, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.Stateid)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.States",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Abbreviation = c.String(nullable: false, maxLength: 4),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contacts", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Contacts", "Stateid", "dbo.States");
            DropIndex("dbo.Contacts", new[] { "UserId" });
            DropIndex("dbo.Contacts", new[] { "Stateid" });
            DropTable("dbo.States");
            DropTable("dbo.Contacts");
        }
    }
}
