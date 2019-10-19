using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IceCreamAPI.Models
{
    public class BookDTO
    {
        public string BookId { get; set; }
        public string Title { get; set; }
        public string Descr { get; set; }
        public DateTime ReleasedDate { get; set; }

        public double Price { get; set; }
    }
}