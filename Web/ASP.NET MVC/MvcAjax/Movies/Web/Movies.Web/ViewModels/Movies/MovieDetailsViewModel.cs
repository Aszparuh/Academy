namespace Movies.Web.ViewModels.Movies
{
    using System.Linq;
    using AutoMapper;
    using Data.Models;
    using Infrastructure.Mappings;

    public class MovieDetailsViewModel : IMapFrom<Movie>, IHaveCustomMappings
    {
        public string MovieDesciption { get; set; }

        public string FemaleActorName { get; set; }

        public string MaleActorName { get; set; }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<Movie, MovieDetailsViewModel>()
                .ForMember(x => x.FemaleActorName, opt => opt.MapFrom(x => x.Actors.Where(a => a.Gender == GenderEnum.Female).FirstOrDefault().Name))
                .ForMember(x => x.MaleActorName, opt => opt.MapFrom(x => x.Actors.Where(a => a.Gender == GenderEnum.Male).FirstOrDefault().Name));
        }
    }
}