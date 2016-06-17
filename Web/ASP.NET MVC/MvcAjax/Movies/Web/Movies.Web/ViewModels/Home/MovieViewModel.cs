namespace Movies.Web.ViewModels.Home
{
    using System;
    using AutoMapper;
    using Data.Models;
    using Infrastructure.Mappings;

    public class MovieViewModel : IMapFrom<Movie>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            throw new NotImplementedException();
        }
    }
}