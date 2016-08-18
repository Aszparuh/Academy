namespace Movies.Services.Data
{
    using System;
    using System.Linq;
    using Contracts;
    using Movies.Data.Common;
    using Movies.Data.Models;

    public class StudioService : IStudioService
    {
        private readonly IDbRepository<Studio> studios;

        public StudioService(IDbRepository<Studio> studios)
        {
            this.studios = studios;
        }

        public void Add(Studio studio)
        {
            this.studios.Add(studio);
            this.studios.Save();
        }

        public void Delete(int id)
        {
            var studioToDelete = this.GetById(id);
            this.studios.Delete(studioToDelete);
            this.studios.Save();
        }

        public IQueryable<Studio> GetAll()
        {
            return this.studios.All();
        }

        public Studio GetById(int id)
        {
            return this.studios.GetById(id);
        }
    }
}
