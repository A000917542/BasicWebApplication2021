using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public int counter = 100;

        public List<Prices> Prices;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;

            Prices = new List<Prices>();
            Prices.Add(new Prices() { Title = "Mover", Description = "You're ready to see results and get moving.", Price = 32M, Features = new List<string>() { "All Basic Features", "Drip Course Content" } });
            Prices.Add(new Prices() { Title = "Shaker", Description = "You're ready to see results and get shaking.", Price = 80M, Features = new List<string>() { "All Basic Features", "Drip Course Content", "Another Feature" } });
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            return Page();
        }


    }
}
