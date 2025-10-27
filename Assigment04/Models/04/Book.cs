using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment04.Models._04
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public BookStatus Status { get; set; }

        public Book(string title, string author, BookStatus status)
        {
            Title = title;
            Author = author;
            Status = status;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Title: {Title}\nAuthor: {Author}\nStatus: {Status}");
        }
    }
}
