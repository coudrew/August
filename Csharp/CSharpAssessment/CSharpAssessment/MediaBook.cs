using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssessment
{
    class MediaBook : Media
    {
        string Author { get; set; }
        string ISBN { get; set; }

        public MediaBook(string title, string price, string author, string isbn) : base(title, price)
        {
            this.Author = author;
            this.ISBN = isbn;
        }

        public override string[] DisplayMediaDetails()
        {
            //base.DisplayMediaDetails();
            string[] mediaData = { "Title: " + this.Title, "Price: " + this.Price, "Author: " + this.Author, "ISBN: " + this.ISBN };
            return mediaData;
        }
    }
}
