using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication2.Models;
using WebApplication2.Services;


namespace WebApplication2.Pages
{
    public class AddEventModel : PageModel
    {
        [BindProperty]
        public Event NewEvent { get; set; } = new Event();

        public bool Submitted { get; set; }

        public void OnPost()
        {
            Submitted = true;
            EventLogger.OnEventCreated?.Invoke(NewEvent);
        }
    }

}
