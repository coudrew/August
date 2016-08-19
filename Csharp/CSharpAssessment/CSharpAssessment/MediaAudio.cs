using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssessment
{
    class MediaAudio : Media
    {
        string Artist { get; set; }
        string ISBN { get; set; }

        public MediaAudio(string title, string price, string artist, string isbn) : base(title, price)
        {
            this.Artist = artist;
            this.ISBN = isbn;
        }
        public override string[] DisplayMediaDetails()
        {
            //base.DisplayMediaDetails();
            string[] mediaData = { "Title: " + this.Title, "Price: " + this.Price, "Artist: " + this.Artist, "ISBN: " + this.ISBN };
            return mediaData;
        }
    }
}
