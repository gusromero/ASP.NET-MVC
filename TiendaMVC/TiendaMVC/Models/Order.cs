using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TiendaMVC.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string UserId { get; set; }

        public ICollection<Line> Lines { get; set; }
    }
}
