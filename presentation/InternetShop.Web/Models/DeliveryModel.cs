﻿using System.Collections.Generic;

namespace InternetShop.Web.Models
{
    public class DeliveryModel
    {
        public int OrderId { get; set; }
        public Dictionary<string, string> Methods { get; set; }
        

    }
}
