namespace PetAdaptation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Gender = c.String(nullable: false, maxLength: 10),
                        Color = c.String(maxLength: 50),
                        Age = c.Int(nullable: false),
                        Description = c.String(maxLength: 500),
                        Characteristic = c.String(maxLength: 500),
                        Species = c.String(nullable: false, maxLength: 50),
                        Weight = c.Single(nullable: false),
                        Location = c.String(maxLength: 100),
                        AddedBy = c.Int(nullable: false),
                        IsAdopted = c.Boolean(nullable: false),
                        AddedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.AddedBy, cascadeDelete: true)
                .Index(t => t.AddedBy);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false),
                        PasswordHash = c.String(nullable: false, maxLength: 255),
                        CreatedTime = c.DateTime(nullable: false),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pets", "AddedBy", "dbo.Users");
            DropForeignKey("dbo.Users", "RoleId", "dbo.Roles");
            DropIndex("dbo.Users", new[] { "RoleId" });
            DropIndex("dbo.Pets", new[] { "AddedBy" });
            DropTable("dbo.Roles");
            DropTable("dbo.Users");
            DropTable("dbo.Pets");
        }
    }
}
