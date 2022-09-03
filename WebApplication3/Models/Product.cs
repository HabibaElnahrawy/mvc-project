using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Category { get; set; }
        public string ProductTitle { get; set; }
        public string ProductPrice { get; set; }
        public string ProductDescription { get; set; }
        




        internal Product find(string id)
        {
            throw new NotImplementedException();
        }
    }
}