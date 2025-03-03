using lab7.Models;
using lab7.Sevices.Abstract;

namespace lab7.Sevices.Implementation
{
    public class MockFilmRepository : IFilmRepository
    {
        private ICollection<Movie> _movies;

        public MockFilmRepository() {
            _movies =new List<Movie>();
        }
        public Movie Create(Movie entity)
        {
            int newId = 0;
            if (_movies.Count > 0 )
                newId = _movies.Max( x => x.Id );
            entity.Id = ++newId;
            _movies.Add( entity );
            return entity;
        }

        public IEnumerable<Movie> GetAll()
        {
            return _movies.ToList();
        }
    }
}
