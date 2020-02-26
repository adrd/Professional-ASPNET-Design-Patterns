﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASPPatterns.Chap8.MVP.Model
{
    public class Product
    {
        public Category Category { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
