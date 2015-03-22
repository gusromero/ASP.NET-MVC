using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TiendaMVC.Models
{
    public class Line
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Units { get; set; }
        public Decimal Price { get; set; }
    }
}
