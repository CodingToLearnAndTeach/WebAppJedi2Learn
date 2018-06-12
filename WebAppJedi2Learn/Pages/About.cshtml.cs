using System;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppJedi2Learn.Pages
{
    public class AboutModel : PageModel
    {
        public string Message { get; set; }

        /*
        public void OnGet()
        {
            Message = "Your application description page.";
        }
        */

        public void OnGet()
        {
            string directory = Environment.CurrentDirectory;
            Message = String.Format("Your directory is {0}.", directory);
        }

    }
}
