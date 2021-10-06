using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public int counter = 100;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            ViewData["Method"] = "Get";
            ViewData["Method"] = "Something";
            ViewData["Title"] = "Something";
            ViewData["int1"] = 100;
            ViewData["bool"] = false;

        }

        public void OnPost()
        {
            ViewData["Method"] = "Post";
            ViewData["bool"] = true;
            counter = 10;
        }


    }
}
