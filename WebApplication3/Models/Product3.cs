using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Product3
    {
        [Key]
        public int ProductId { get; set; }
        public string Category { get; set; }
        public string ProductTitle { get; set; }
        public string ProductPrice { get; set; }
        public string ProductDescription { get; set; }
    }
}