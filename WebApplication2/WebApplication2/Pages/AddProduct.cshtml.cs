using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication2.Pages
{
    public class AddProductModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; }

        [BindProperty]
        public decimal Price { get; set; }

        public bool Submitted { get; set; }

        public void OnPost()
        {
            Submitted = true;
        }
    }

}
