using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace lab7.Pages.Films
{ 

    public class AddModel : PageModel
    {
        [BindProperty]
        public int Age { get; set; }
        [BindProperty]
        [Required]
        [MinLength(6)]
        public string Firstname { get; set; }= string.Empty;

        public string? ErrorMessage { get; set; }
        public void OnGet()
        {
        }
        public void OnPost() {
            if (!ModelState.IsValid) { }
        }
    }
}
