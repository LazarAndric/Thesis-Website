using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Undergraduate_thesis.Models;

namespace Undergraduate_thesis
{
    public class FormModel : PageModel
    {
        [BindProperty]
        public FormAdress Adress { get; set; }

        public IActionResult OnPostAsync() 
        {
            return Page();
        }
    }
}