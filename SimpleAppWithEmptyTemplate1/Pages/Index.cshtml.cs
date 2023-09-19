using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SimpleAppWithEmptyTemplate1.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            ViewData["message"] = "Message from the page model1";
        }
    }
}
