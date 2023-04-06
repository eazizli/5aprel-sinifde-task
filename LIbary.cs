using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6AprelWorkTask
{
    internal class LIbary
    {
        Book[] books = new Book[0];
        public void AddBook(Book book)
        {
            Array.Resize(ref books, books.Length+1);
            books[books.Length-1] = book;
        }
        public void GetBook(int Id)

        {
            foreach (Book book in books)
            {
                if (book.Id == Id)
                {
                    Console.WriteLine($"{book.Name} + {book.AuthorName} + {book.Code}");
                }
            }    
            
        }
        public void AllBooks()
        {
            foreach(Book book in books)
            {
                Console.WriteLine($"{book.Name}  {book.AuthorName}  {book.Code}  {book.Price}  {book.PageCount}");
            }
        }

    }
}
