namespace Movies.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
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

        public void Edit(Movie movie, IEnumerable<Actor> newActors)
        {
            movie.Actors = new List<Actor>(newActors);
            this.movies.Update(movie);
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

        public Movie GetByIdWithActors(int id)
        {
            return this.GetAll().Where(m => m.Id == id).Include(m => m.Actors).FirstOrDefault();
        }

        public IQueryable GetByIdWithActorsAsQueryable(int id)
        {
            return this.GetAll().Where(m => m.Id == id).Include(m => m.Actors);
        }

        public void Hide(int id)
        {
            var movie = this.GetById(id);

            if (movie != null)
            {
                this.movies.Delete(movie);
                this.movies.Save();
            }
        }

        public void Save()
        {
            this.movies.Save();
        }
    }
}
