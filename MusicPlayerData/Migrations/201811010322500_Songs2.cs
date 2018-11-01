namespace MusicPlayerData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Songs2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Songs", "Category", c => c.String());
            AddColumn("dbo.Songs", "YearOfRelease", c => c.DateTime(nullable: false));
            AddColumn("dbo.Songs", "AlbumCover", c => c.Binary());
            DropColumn("dbo.Songs", "Genre");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Songs", "Genre", c => c.String());
            DropColumn("dbo.Songs", "AlbumCover");
            DropColumn("dbo.Songs", "YearOfRelease");
            DropColumn("dbo.Songs", "Category");
        }
    }
}
