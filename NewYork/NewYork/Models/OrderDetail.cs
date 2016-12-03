using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewYork.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int ShowId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public virtual Show show { get; set; }
        public virtual Order Order { get; set; }
    }
}