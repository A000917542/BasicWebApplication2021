using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Models;

namespace WebApplication1.Pages
{
    public class BiosModel : PageModel
    {
        [FromForm]
        public Bio Bio { get; set; }

        public void OnGet()
        {
            if(!ModelState.IsValid)
            {
                Bio.Name = "new namespace";
            }
        }
    }
}
