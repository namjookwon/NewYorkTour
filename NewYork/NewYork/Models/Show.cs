using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewYork.Models
{
    public class Show
    {
        public virtual int ShowId { get; set; }
        public virtual int GenreId { get; set; }
        public virtual string Title { get; set; }
        public virtual string Theatre { get; set; }
        public virtual string ImageUrl { get; set; }
        public virtual decimal Price { get; set; }
        public virtual Genre Genre { get; set; }
    }
}