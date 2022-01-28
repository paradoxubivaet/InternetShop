﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop.Data
{
    public class OrderItemDto
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public OrderDto Order { get; set; }
    }
}
