﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TiendaMVC.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }

        public ICollection<Line> Lines { get; set; }
    }
}
