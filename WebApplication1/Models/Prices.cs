using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Prices
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public List<string> Features { get; set; }
    }
}
