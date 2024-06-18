namespace FamilyLibraryManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Author = c.String(),
                        OwnerId = c.Int(nullable: false),
                        ShelveNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Owners", t => t.OwnerId, cascadeDelete: true)
                .Index(t => t.OwnerId);
            
            CreateTable(
                "dbo.BorrowedBooks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BookId = c.Int(nullable: false),
                        BorrowerName = c.String(),
                        BorrowerLastName = c.String(),
                        BorrowedDate = c.DateTime(nullable: false),
                        OwnerId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .ForeignKey("dbo.Owners", t => t.OwnerId)
                .Index(t => t.BookId)
                .Index(t => t.OwnerId);
            
            CreateTable(
                "dbo.Owners",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "OwnerId", "dbo.Owners");
            DropForeignKey("dbo.BorrowedBooks", "OwnerId", "dbo.Owners");
            DropForeignKey("dbo.BorrowedBooks", "BookId", "dbo.Books");
            DropIndex("dbo.BorrowedBooks", new[] { "OwnerId" });
            DropIndex("dbo.BorrowedBooks", new[] { "BookId" });
            DropIndex("dbo.Books", new[] { "OwnerId" });
            DropTable("dbo.Owners");
            DropTable("dbo.BorrowedBooks");
            DropTable("dbo.Books");
        }
    }
}
