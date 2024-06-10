namespace MovieProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMovieModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "YearOfRelease", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "YearOfRelease", c => c.Int(nullable: false));
        }
    }
}
