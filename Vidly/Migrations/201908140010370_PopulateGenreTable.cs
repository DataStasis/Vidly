namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO dbo.Genres (Id, Name) VALUES (1, 'Action')");
            Sql("INSERT INTO dbo.Genres (Id, Name) VALUES (2, 'Horror')");
            Sql("INSERT INTO dbo.Genres (Id, Name) VALUES (3, 'Comedy')");
            Sql("INSERT INTO dbo.Genres (Id, Name) VALUES (4, 'Thriller')");
            Sql("INSERT INTO dbo.Genres (Id, Name) VALUES (5, 'Romance')");
        }
        
        public override void Down()
        {
        }
    }
}
