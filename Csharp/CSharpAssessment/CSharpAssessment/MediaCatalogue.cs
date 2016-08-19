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
            int searchType = currentType;
            switch (searchType)
            {
                case 0:
                    foreach (MediaBook book in Catalogue)
                    {
                        if (book.Title == searchParam)
                        {
                            media = book;
                            return media;
                        }
                    }
                    break;
                case 1:
                    foreach (MediaPeriodical magazine in Catalogue)
                    {
                        if (magazine.Title == searchParam)
                        {
                            media = magazine;
                            return media;
                        }
                    }
                    break;
                case 2:
                    foreach (MediaAudio audio in Catalogue)
                    {
                        if (audio.Title == searchParam)
                        {
                            media = audio;
                            return media;
                        }
                    }
                    break;
                case 3:
                    foreach (MediaVideo video in Catalogue)
                    {
                        if (video.Title == searchParam)
                        {
                            media = video;
                            return media;
                        }
                    }
                    break;
                default:
                    media = new Media("Not Found", "0.00");
                    return media;
            }
            return media;
        }
        
    }
}
