namespace Gamely.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCreateAndEditFunctions : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Games", name: "GameGenre_Id", newName: "GameGenreId");
            RenameIndex(table: "dbo.Games", name: "IX_GameGenre_Id", newName: "IX_GameGenreId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Games", name: "IX_GameGenreId", newName: "IX_GameGenre_Id");
            RenameColumn(table: "dbo.Games", name: "GameGenreId", newName: "GameGenre_Id");
        }
    }
}
