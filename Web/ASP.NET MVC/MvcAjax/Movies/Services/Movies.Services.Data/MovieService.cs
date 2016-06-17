namespace Movies.Services.Data
{
    using System;
    using System.Linq;
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
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Movie> GetAll()
        {
            throw new NotImplementedException();
        }

        public Movie GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
