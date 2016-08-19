using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssessment
{
    class MediaCatalogue
    {
        List<Media> Catalogue = new List<Media>(); //actual catalogue to hold all media
        public int currentType { get; set; }
        //method to add media to the catalogue
        public void AddToCatalogue(Media media)
        {
            this.Catalogue.Add(media);
        }

        //method to remove media from the catalogue
        public void RemoveFromCatalogue(string title)
        {
            foreach (Media media in Catalogue)
            {
                if (media.Title == title)
                {
                    Catalogue.Remove(media);
                }
            }
            
        }

        //method to find and return media from the catalogue
        public Media SearchCatalogue(string searchParam)
        {
            Media media = new Media("Not Found", "0.00");
            foreach (Media item in Catalogue)
            {
                if (item.Title == searchParam)
                {
                    media = item;
                    return media;
                }
            }
            
            return media;
        }
        
    }
}
