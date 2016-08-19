using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssessment
{
    class MediaVideo : Media
    {
        string Director { get; set; }
        string ISBN { get; set; }

        public MediaVideo(string title, string price, string director, string isbn) : base(title, price)
        {
            this.Director = director;
            this.ISBN = isbn;
        }
        public override string[] DisplayMediaDetails()
        {
            //base.DisplayMediaDetails();
            string[] mediaData = { "Title: " + this.Title, "Price: " + this.Price, "Director/Producer: " + this.Director, "ISBN: " + this.ISBN };
            return mediaData;
        }
    }
}
