namespace Gamely.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGameGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO GameGenres (Id, Name) VALUES (1, 'FPS')");
            Sql("INSERT INTO GameGenres (Id, Name) VALUES (2, 'TPS')");
            Sql("INSERT INTO GameGenres (Id, Name) VALUES (3, 'RTS')");
            Sql("INSERT INTO GameGenres (Id, Name) VALUES (4, 'RPG')");
            Sql("INSERT INTO GameGenres (Id, Name) VALUES (5, 'Race')");
            Sql("INSERT INTO GameGenres (Id, Name) VALUES (6, 'Simulator')");
            Sql("INSERT INTO GameGenres (Id, Name) VALUES (7, 'Sandbox')");
        }
        
        public override void Down()
        {
        }
    }
}
