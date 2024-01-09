using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyCoreApp.Pages
{
    public class ProjectsModel : PageModel
    {
        public void OnGet()
        {
            Console.WriteLine("Projects selected");
        }
    }
}
