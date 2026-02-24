using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Portfolio.Pages;

public class IndexModel : PageModel
{
    // add properties to store project and skill arrays
    public Project[] Projects {get; set;}
    public Skill[] Skills {get; set;}

    // OnGet() method executes automatically when page is opened
    public void OnGet()
    {
        
    }
}
