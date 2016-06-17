namespace Movies.Services.Data
{
    using System.Linq;
    using Movies.Data.Models;

    public interface IMovieService
    {
        IQueryable<Movie> GetAll();

        Movie GetById(int id);

        void Add(Movie movie);

        void Delete(int id);

        void Update(int id);
    }
}
