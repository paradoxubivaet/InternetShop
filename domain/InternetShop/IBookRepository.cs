﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop
{
    public interface IBookRepository
    {
        Book[] GetAllByTitle(string titlePart);
    }
}
