namespace Movies.Services.Data.Contracts
{
    using System;
    using System.Linq;
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
        }

        public void Delete(int id)
        {
            var studioToDelete = this.GetById(id);
            this.studios.Delete(studioToDelete);
        }

        public IQueryable<Studio> GetAll()
        {
            return this.studios.All();
        }

        public Studio GetById(int id)
        {
            return this.studios.GetById(id);
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
