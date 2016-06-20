namespace Movies.Services.Data
{
    using System;
    using System.Linq;
    using Movies.Data.Common;
    using Movies.Data.Models;
    using Movies.Services.Data.Contracts;

    public class ActorService : IActorService
    {
        private readonly IDbRepository<Actor> actors;

        public ActorService(IDbRepository<Actor> actors)
        {
            this.actors = actors;
        }

        public void Add(Actor actor)
        {
            this.actors.Add(actor);
            this.actors.Save();
        }

        public IQueryable<Actor> GetAll()
        {
            return this.actors.All();
        }

        public IQueryable<Actor> GetAllFemale()
        {
            return this.actors.All().Where(a => a.Gender == GenderEnum.Female);
        }

        public IQueryable<Actor> GetAllMale()
        {
            return this.actors.All().Where(a => a.Gender == GenderEnum.Male);
        }

        public Actor GetById(int id)
        {
            return this.actors.GetById(id);
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
