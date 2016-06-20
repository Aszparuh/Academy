namespace Movies.Services.Data
{
    using System;
    using System.Linq;
    using Contracts;
    using Movies.Data.Common;
    using Movies.Data.Models;

    public class MovieService : IMovieService
    {
        private readonly IDbRepository<Movie> movies;

        public MovieService(IDbRepository<Movie> movies)
        {
            this.movies = movies;
        }

        public void Add(Movie movie)
        {
            this.movies.Add(movie);
            this.movies.Save();
        }

        public void Delete(int id)
        {
            var movieToDelete = this.movies.GetById(id);
            this.movies.Delete(movieToDelete);
            this.movies.Save();
        }

        public IQueryable<Movie> GetAll()
        {
            return this.movies.All();
        }

        public Movie GetById(int id)
        {
            return this.movies.GetById(id);
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
