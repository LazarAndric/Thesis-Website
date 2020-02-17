using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Undergraduate_thesis
{
    public class O_namaModel : PageModel
    {
        public string MyProperty { get; set; }
        public float Sum { get; set; }
        public void OnGet()
        {
        }
    }
}