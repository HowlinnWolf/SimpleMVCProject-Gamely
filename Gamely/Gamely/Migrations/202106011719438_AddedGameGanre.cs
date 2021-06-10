namespace Gamely.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedGameGanre : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        ReleaseDate = c.DateTime(nullable: false),
                        DateAdded = c.DateTime(nullable: false),
                        NumberInStock = c.Byte(nullable: false),
                        Genre_Id = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.GameGenres", t => t.Genre_Id, cascadeDelete: true)
                .Index(t => t.Genre_Id);
            
            CreateTable(
                "dbo.GameGenres",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Games", "Genre_Id", "dbo.GameGenres");
            DropIndex("dbo.Games", new[] { "Genre_Id" });
            DropTable("dbo.GameGenres");
            DropTable("dbo.Games");
        }
    }
}
