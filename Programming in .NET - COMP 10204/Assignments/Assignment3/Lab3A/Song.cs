using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// I, Thomas Coons, 000317961 certify that this material is my original work.  No other person's work has been used without due acknowledgement.
// Date: November 2nd 2024
namespace Lab3A
{
    /// <summary>
    /// The Song Class
    /// </summary>
    internal class Song : Media
    {
        public string Album { get; }
        public string Artist { get; }

        /// <summary>
        /// Song Constructor
        /// </summary>
        /// <param name="title">Title of song</param>
        /// <param name="year">Year of song</param>
        /// <param name="album">Album of song</param>
        /// <param name="artist">Artist of song</param>
        public Song (string title, int year, string album, string artist) : base(title, year)
        {
            Album = album;
            Artist = artist;
        }

        /// <summary>
        /// Overrided ToString
        /// </summary>
        /// <returns>String representation of the song with Title, Year, Album, and Artist</returns>
        public override string ToString()
        {
            return $"Song Title: {Title} ({Year}) \nAlbum: {Album} | Artist: {Artist}\n--------------------";
        }
    }
}
