using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment04.Models._04
{
    public class Library
    {
        private List<Book> books = new List<Book>();

       
        public void AddBook(Book book)
        {
            books.Add(book);
        }

        
        public Book this[string title]
        {
            get
            {
                return books.FirstOrDefault(b => b.Title == title);
            }
        }

        
        public void ChangeStatus(string title, BookStatus newStatus)
        {
            Book book = this[title];
            if (book != null)
            {
                book.Status = newStatus;
                Console.WriteLine($"Status of {title} changed to {newStatus}");
            }
            else
            {
                Console.WriteLine($"Book {title} not found.");
            }
        }

       
        public void ShowBooksByStatus(BookStatus status)
        {
            Console.WriteLine($"\nBooks with status: {status}");
            var filtered = books.Where(b => b.Status == status).ToList();

            if (filtered.Count == 0)
            {
                Console.WriteLine("No books found with this status.");
            }
            else
            {
                foreach (var b in filtered)
                {
                    b.ShowInfo();
                }
            }
        }
    }
}
