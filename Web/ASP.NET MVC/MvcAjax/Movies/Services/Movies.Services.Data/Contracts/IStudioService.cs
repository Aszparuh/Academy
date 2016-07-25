namespace Movies.Services.Data.Contracts
{
    using System.Linq;
    using Movies.Data.Models;

    public interface IStudioService
    {
        IQueryable<Studio> GetAll();

        Studio GetById(int id);

        void Add(Studio studio);

        void Delete(int id);

        void Update(int id);
    }
}
