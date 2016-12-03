using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NewYork.Models;

namespace NewYork.ViewModels
{
    public class ShoppingCartViewModel
    {
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}