using System;
using System.Linq;

namespace InternetShop.Memory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new[]
        {
            new Book(1,"ISBN 32561-34671","D. Knuth", "Art Of Programming"),
            new Book(2, "ISBN 32561-34672", "M. Fowler", "Refactoring"),
            new Book(3, "ISBN 32561-34673", "B. Kernighan, D. Ritchie" ,"C Programming Language")
        };

        public Book[] GetAllByIsbn(string isbn)
        {
            return books.Where(book => book.Isbn == isbn)
                      .ToArray();
        }

        public Book[] GetAllByTitleOrAuthor(string query)
        {
            return books.Where(book => book.Title.Contains(query) 
                                    || book.Author.Contains(query))
                .ToArray();
        }
    }
}
