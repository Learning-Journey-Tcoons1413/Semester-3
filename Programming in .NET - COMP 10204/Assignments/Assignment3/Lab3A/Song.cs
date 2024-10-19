﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3A
{
    internal class Song : Media
    {
        public string Album { get; }
        public string Artist { get; }
        public Song (string title, int year, string album, string artist) : base(title, year)
        {
            Album = album;
            Artist = artist;
        }
        public override string ToString()
        {
            return $"Song Title: {Title} ({Year}) \nAlbum: {Album} | Artist: {Artist}\n--------------------";
        }
    }
}
