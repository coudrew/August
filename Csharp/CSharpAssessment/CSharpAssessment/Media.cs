using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssessment
{
    class Media
    {
        //Base class that media types are derived from, all types will have a title and price
        public string Title { get; set; }
        public string Price { get; set; }

        public Media(string title, string price)
        {
            this.Title = title;
            this.Price = price;
        }

        public virtual string[] DisplayMediaDetails()
        {
            string[] temp = { "", "" };
            return temp;
        }
    }
}
