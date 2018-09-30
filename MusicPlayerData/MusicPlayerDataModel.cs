namespace MusicPlayerData
{
    using MusicPlayerData.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class MusicPlayerDataModel : DbContext
    {
        // Your context has been configured to use a 'MusicPlayerDataModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'MusicPlayerData.MusicPlayerDataModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'MusicPlayerDataModel' 
        // connection string in the application configuration file.
        public MusicPlayerDataModel()
            : base("name=MusicPlayerDataModel")
        {
        }

        public virtual DbSet<Song> Songs { get; set; }
    }
}