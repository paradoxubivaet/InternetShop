﻿using System;
using System.Collections.Generic;

namespace InternetShop.Data.EF
{
    class BookRepository : IBookRepository
    {
        public Book[] GetAllByIds(IEnumerable<int> bookIds)
        {
            throw new NotImplementedException();
        }

        public Book[] GetAllByIsbn(string isbn)
        {
            throw new NotImplementedException();
        }

        public Book[] GetAllByTitleOrAuthor(string titleOrAuthor)
        {
            throw new NotImplementedException();
        }

        public Book GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
