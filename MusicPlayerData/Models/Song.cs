using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayerData.Models
{
    public class Song
    {
        public Guid SongId { get; set; }
        public string SongName { get; set; }
        public string ContentType { get; set; }
        public byte[] Content { get; set; }
        public bool Favorite { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public string Lyrics { get; set; }
        public string Category { get; set; }
        public DateTime YearOfRelease {get; set;}
        public byte[] AlbumCover { get; set; }
    }
}
