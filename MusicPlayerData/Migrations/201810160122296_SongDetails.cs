namespace MusicPlayerData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SongDetails : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Songs", "ContentType", c => c.String());
            AddColumn("dbo.Songs", "Content", c => c.Binary());
            AddColumn("dbo.Songs", "Favorite", c => c.Boolean(nullable: false));
            AddColumn("dbo.Songs", "Artist", c => c.String());
            AddColumn("dbo.Songs", "Album", c => c.String());
            AddColumn("dbo.Songs", "Lyrics", c => c.String());
            AddColumn("dbo.Songs", "Genre", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Songs", "Genre");
            DropColumn("dbo.Songs", "Lyrics");
            DropColumn("dbo.Songs", "Album");
            DropColumn("dbo.Songs", "Artist");
            DropColumn("dbo.Songs", "Favorite");
            DropColumn("dbo.Songs", "Content");
            DropColumn("dbo.Songs", "ContentType");
        }
    }
}
