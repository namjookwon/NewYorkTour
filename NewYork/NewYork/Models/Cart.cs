using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewYork.Models
{
    public class Cart
    {
        [Key]
        public int RecordId { get; set; }
        public string CartId { get; set; }
        public int ShowId { get; set; }
        public int Count { get; set; }


        public DateTime DateCreated { get; set; }

        public virtual Show show { get; set; }
    }
}