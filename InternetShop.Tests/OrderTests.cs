﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace InternetShop.Tests
{
    public class OrderTests
    {
        [Fact]
        public void Order_WithNullItems_ThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new Order(1, null));
        }

        [Fact]
        public void TotalCount_WithEmptyItems_ReturnZero()
        {
            var order = new Order(1, new OrderItem[0]);

            Assert.Equal(0, order.TotalCount);
        }

        [Fact]
        public void TotalPrice_WithEmptyItems_ReturnZero()
        {
            var order = new Order(1, new OrderItem[0]);

            Assert.Equal(0m, order.TotalCount);
        }

        [Fact]
        public void TotalCount_WithNotEmptyItems_CalculatesTotalCount()
        {
            var order = new Order(1, new[]
            {
                new OrderItem(1,3,10m),
                new OrderItem(2,5,100m),
            });

            Assert.Equal(3 + 5, order.TotalCount);
        }

        [Fact]
        public void TotalPrice_WithNotEmptyItems_CalculatesTotalPrice()
        {
            var order = new Order(1, new[]
            {
                new OrderItem(1,3,10m),
                new OrderItem(2,5,100m),
            });

            Assert.Equal(3*10m + 5*100m, order.TotalPrice);
        }
    }
}
