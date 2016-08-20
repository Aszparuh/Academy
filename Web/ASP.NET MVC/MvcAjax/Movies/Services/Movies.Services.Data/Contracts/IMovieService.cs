namespace Movies.Services.Data.Contracts
{
    using System.Collections.Generic;
    using System.Linq;
    using Movies.Data.Models;

    public interface IMovieService
    {
        IQueryable<Movie> GetAll();

        Movie GetByIdWithActors(int id);

        IQueryable GetByIdWithActorsAsQueryable(int id);

        Movie GetById(int id);

        void Add(Movie movie);

        void Delete(int id);

        void Save();

        void Edit(Movie movie, IEnumerable<Actor> actors);
    }
}
