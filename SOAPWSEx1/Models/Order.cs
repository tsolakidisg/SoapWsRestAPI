﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOAPWSEx1.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int Fees { get; set; }
        public string OrderStatus { get; set; }
    }
}
