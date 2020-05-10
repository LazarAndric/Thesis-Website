using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Undergraduate_thesis.Models;
using ServiceReference1;

namespace Undergraduate_thesis
{
    public class FormModel : PageModel
    {
        Service1Client client = new Service1Client();
        [BindProperty]
        public FormAdress Adress { get; set; }

        public IActionResult OnPostAsync() 
        {
            if (ModelState.IsValid == false)
                return Page();
            client.Sum(5, 4);
            //Save Model to Database
            return RedirectToPage("Index");
        }
    }
}