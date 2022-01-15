using System;
using System.Collections.Generic;
using System.Linq;

namespace InternetShop
{
    public class Order
    {
        public int Id { get; }

        public OrderItemCollection Items { get; }
        public OrderDelivery Delivery { get; set; }
        public OrderPayment Payment { get; set; }
        public string CellPhone { get; set;}
        public int TotalCount => Items.Sum(x => x.Count);

        public decimal TotalPrice => Items.Sum(x => x.Price * x.Count)
                                   + (Delivery?.Amount ?? 0m);

        public Order(int id, IEnumerable<OrderItem> items)
        {
            Id = id;
            Items = new OrderItemCollection(items);
        }

        private void ThrowBookException(string message, int bookId)
        {
            var exception = new InvalidOperationException(message);

            exception.Data["BookId"] = bookId;

            throw exception;
            
        }
    }
}
