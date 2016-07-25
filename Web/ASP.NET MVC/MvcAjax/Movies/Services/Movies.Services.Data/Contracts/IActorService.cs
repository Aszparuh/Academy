namespace Movies.Services.Data.Contracts
{
    using System.Linq;
    using Movies.Data.Models;

    public interface IActorService
    {
        IQueryable<Actor> GetAll();

        IQueryable<Actor> GetAllFemale();

        IQueryable<Actor> GetAllMale();

        Actor GetById(int id);

        void Add(Actor actor);

        void Update(int id);

        void Delete(int id);
    }
}
