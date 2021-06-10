namespace Gamely.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IdentityModelsChangedMaybe : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Games", name: "Genre_Id", newName: "GameGenre_Id");
            RenameIndex(table: "dbo.Games", name: "IX_Genre_Id", newName: "IX_GameGenre_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Games", name: "IX_GameGenre_Id", newName: "IX_Genre_Id");
            RenameColumn(table: "dbo.Games", name: "GameGenre_Id", newName: "Genre_Id");
        }
    }
}
