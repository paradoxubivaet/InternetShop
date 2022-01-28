﻿using InternetShop.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InternetShop
{
    public class Order
    {
        private readonly OrderDto dto;
        public int Id => dto.Id;
        public OrderDelivery Delivery
        {
            get
            {
                if (dto.DeliveryUniqueCode == null)
                    return null;

                return new OrderDelivery(
                    dto.DeliveryUniqueCode,
                    dto.DeliveryDescription,
                    dto.DeliveryPrice,
                    dto.DeliveryParameters
                );
            }
            set
            {
                if (value == null)
                    throw new ArgumentException(nameof(Delivery));

                dto.DeliveryUniqueCode = value.UniqueCode;
                dto.DeliveryDescription = value.Description;
                dto.DeliveryPrice = value.Price;
                dto.DeliveryParameters = value.Parametrs.ToDictionary(p => p.Key, p => p.Value);
            }
        }
        public OrderPayment Payment
        {
            get
            {
                if (dto.PaymentServiceName == null)
                    return null;

                return new OrderPayment(
                    dto.PaymentServiceName,
                    dto.PaymentDescription,
                    dto.DeliveryParameters);
            }
            set
            {
                if (value == null)
                    throw new ArgumentException(nameof(Payment));

                dto.PaymentServiceName = value.UniqieCode;
                dto.PaymentDescription = value.Description;
                dto.PaymentParameters = value.Parametrs.ToDictionary(p => p.Key, p => p.Value);
            }
        }
        public string CellPhone 
        {
            get => dto.CellPhone;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException(nameof(CellPhone));

                dto.CellPhone = value;
            }
        }
        
        public OrderItemCollection Items { get; }

        public int TotalCount => Items.Sum(x => x.Count);

        public decimal TotalPrice => Items.Sum(x => x.Price * x.Count)
                                   + (Delivery?.Price ?? 0m);

        public Order(OrderDto dto)
        {
            this.dto = dto;
            Items = new OrderItemCollection(dto);
        }

        public static class DtoFactory
        {
            public static OrderDto Create() => new OrderDto();

        }

        public static class Mapper
        {
            public static Order Map(OrderDto dto) => new Order(dto);

            public static OrderDto Map(Order domain) => domain.dto;
        }
    }
}
