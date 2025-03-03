using lab7.Models;
using Microsoft.EntityFrameworkCore;

namespace lab7.Data
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options):
            base(options){ 
            Database.EnsureCreated();
        }
        public DbSet<Movie> Movies { get; set; }
    }
}
