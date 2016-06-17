namespace Movies.Services.Data.Contracts
{
    using System.Linq;
    using Movies.Data.Models;

    public interface IActorService
    {
        IQueryable<Actor> GetAll();

        Actor GetById(int id);

        void Add(Actor actor);

        void Update(int id);
    }
}
