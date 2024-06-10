namespace MovieProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Directors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        NationalityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Nationalities", t => t.NationalityId, cascadeDelete: true)
                .Index(t => t.NationalityId);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MovieCategoryID = c.Int(nullable: false),
                        Title = c.String(),
                        DirectorID = c.Int(nullable: false),
                        DurationInMinutes = c.Int(nullable: false),
                        YearOfRelease = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Directors", t => t.DirectorID)
                .ForeignKey("dbo.MovieCategories", t => t.MovieCategoryID)
                .Index(t => t.MovieCategoryID)
                .Index(t => t.DirectorID);
            
            CreateTable(
                "dbo.MovieCategories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.MovieReviewMovies",
                c => new
                    {
                        MovieReviewID = c.Int(nullable: false),
                        MovieID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.MovieReviewID, t.MovieID })
                .ForeignKey("dbo.Movies", t => t.MovieID)
                .ForeignKey("dbo.MovieReviews", t => t.MovieReviewID)
                .Index(t => t.MovieReviewID)
                .Index(t => t.MovieID);
            
            CreateTable(
                "dbo.MovieReviews",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MovieID = c.Int(nullable: false),
                        Score = c.Int(nullable: false),
                        ReviewDate = c.DateTime(nullable: false),
                        Comment = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Movies", t => t.MovieID)
                .Index(t => t.MovieID);
            
            CreateTable(
                "dbo.Nationalities",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Directors", "NationalityId", "dbo.Nationalities");
            DropForeignKey("dbo.MovieReviewMovies", "MovieReviewID", "dbo.MovieReviews");
            DropForeignKey("dbo.MovieReviews", "MovieID", "dbo.Movies");
            DropForeignKey("dbo.MovieReviewMovies", "MovieID", "dbo.Movies");
            DropForeignKey("dbo.Movies", "MovieCategoryID", "dbo.MovieCategories");
            DropForeignKey("dbo.Movies", "DirectorID", "dbo.Directors");
            DropIndex("dbo.MovieReviews", new[] { "MovieID" });
            DropIndex("dbo.MovieReviewMovies", new[] { "MovieID" });
            DropIndex("dbo.MovieReviewMovies", new[] { "MovieReviewID" });
            DropIndex("dbo.Movies", new[] { "DirectorID" });
            DropIndex("dbo.Movies", new[] { "MovieCategoryID" });
            DropIndex("dbo.Directors", new[] { "NationalityId" });
            DropTable("dbo.Nationalities");
            DropTable("dbo.MovieReviews");
            DropTable("dbo.MovieReviewMovies");
            DropTable("dbo.MovieCategories");
            DropTable("dbo.Movies");
            DropTable("dbo.Directors");
        }
    }
}
