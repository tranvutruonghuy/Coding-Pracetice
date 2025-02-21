using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class PublicationManager : IPrintable
    {
        public List<Publication> Publications { get; set; }

        public PublicationManager(List<Publication> publications)
        {
            Publications = publications;
        }
        public void AddBookToList(Publication publication)
        {
            this.Publications.Add(publication);
        }
        public Publication SearchPublcationByTitle(string title)
        {
            Publication result = null;
            foreach (Publication publication in this.Publications)
            {
                if (publication.Title.ToLower() == title.ToLower())
                {
                    result = publication;
                }
            }
            return result;
        }
        public List<Publication> SearchPublicationByCategory(string category)
        {
            List<Publication> publications = new List<Publication>();
            foreach (Publication publication in this.Publications)
            {
                if (publication.Category.ToLower() == category.ToLower())
                {
                    publications.Add(publication);
                }
            }
            return publications;
        }

        public void PrintDetails()
        {
            Console.WriteLine("Publication List: ");
            foreach (Publication publication in this.Publications)
            {
                publication.PrintDetails();
                Console.WriteLine();
            }
        }
    }
}
