using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductApi.Models
{
    public class Product
    {
        public string ProductName { get; set; }
        public string ProductId { get; set; }
        public string Amount { get; set; }
        public string Price { get; set; } 
    }
}
