using lab7.Models;
using lab7.Sevices.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace lab7.Pages.Films
{
    public class IndexModel : PageModel
    {
        public IEnumerable<Movie> Movies { get; set; }
        public IndexModel(IFilmRepository repository)
        {
            Movies = repository.GetAll();
        }
        public void OnGet()
        {
        }
    }
}
