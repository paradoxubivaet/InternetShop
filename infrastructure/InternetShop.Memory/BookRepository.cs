using System;
using System.Collections.Generic;
using System.Linq;

namespace InternetShop.Memory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new[]
        {
            new Book(1,"ISBN 32561-34671","D. Knuth", "Art Of Programming", "This volume begins with basic programming concepts" +
                       "and techniqs", 7.19m),
            new Book(2, "ISBN 32561-34672", "M. Fowler", "Refactoring", "As the application of object technology--particulary the Java", 12.45m),
            new Book(3, "ISBN 32561-34673", "B. Kernighan, D. Ritchie" ,"C Programming Language", "Known as the bible of C, this classic" +
                        "bestseller introduces", 14.98m)
        };

        public Book[] GetAllByIds(IEnumerable<int> bookIds)
        {
            var foundBooks = from book in books
                             join bookId in bookIds on book.Id equals bookId
                             select book;

            return foundBooks.ToArray();
        }

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

        public Book GetById(int id)
        {
            return books.Single(book => book.Id == id);
        }
    }
}
