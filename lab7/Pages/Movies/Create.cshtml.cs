using lab7.Models;
using lab7.Sevices.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace lab7.Pages.Movies
{
    [IgnoreAntiforgeryToken]
    public class CreateModel : PageModel
    {
        private readonly IFilmRepository repository;
       
        public CreateModel(IFilmRepository repository)
        {
            this.repository = repository;
        }
        [BindProperty]
        public Movie? Movie { get; set; }
        public void OnGet()
        {
           
        }

        public void OnPost(string title) 
        {
            if (ModelState.IsValid && Movie is not null)
            {
                repository.Create(Movie);
            }
        }
    }
}
