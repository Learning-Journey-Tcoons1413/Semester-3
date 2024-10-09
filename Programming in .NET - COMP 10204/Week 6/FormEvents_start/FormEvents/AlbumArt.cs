using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FormEvents
{
    /// <summary>
    /// Class to Hold Albums
    /// COMP-10204 - Lecture # 6 - Mark Yendt October 2019
    /// </summary>
    
    class AlbumArt
    {
        public string Description { get; private set;}
        public string Title { get; private set; }
        public string AlbumArtist { get; private set; }
        public string CoverArtist { get; private set; }
        public Image Cover { get; private set; }

        public AlbumArt(string albumArtist, string title, string coverArtist, string filename, string description)
        {
            Title = title;
            AlbumArtist = albumArtist;
            CoverArtist = coverArtist;
            Cover = Image.FromFile(filename);
            Description = description;
        }
    }
}
