using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_control_tab_app
{
    public class Book
    {
        public int Id { get; set; }
        private static int TotalBook = 1;
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string ReleaseDate { get; set;}

        public Book(string title, string description, string author, string releaseDate)
        {
            Id = TotalBook++;
            Title = title;
            Description = description;
            Author = author;
            ReleaseDate = releaseDate;
        }
    }
}
