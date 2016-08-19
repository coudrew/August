using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssessment
{
    class MediaPeriodical : Media
    {
        public string Publisher { get; set; }
        public string ISSN { get; set; }

        public MediaPeriodical(string title, string price, string publisher, string issn) : base(title, price)
        {
            this.Publisher = publisher;
            this.ISSN = issn;
        }

        public override string[] DisplayMediaDetails()
        {
            //base.DisplayMediaDetails();
            string[] mediaData = { "Title: " + this.Title, "Price: " + this.Price, "Publisher: " + this.Publisher, "ISSN: " + this.ISSN };
            return mediaData;
        }
    }
}
