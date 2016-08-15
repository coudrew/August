using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresList
{
    class Book
    {
        public string Author;
        public string Title;
        public Book(string title, string author)
        {
            this.Author = author;
            this.Title = title;
        }
    }
}
