namespace MvcEssentials.Web.ViewModels.Partials
{
    using System;
    using System.Linq;
    using AutoMapper;
    using Data.Models;
    using Infrastructure.Mapping;

    public class NewsArticleAsideViewModel : IMapFrom<NewsArticle>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int? SmallThumbnailId { get; set; }

        public DateTime CreatedOn { get; set; }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<NewsArticle, NewsArticleAsideViewModel>()
                .ForMember(x => x.UserName, opt => opt.MapFrom(x => x.Author.UserName))
                .ForMember(x => x.ImageId, opt => opt.MapFrom(
                    x => x.Images.Where(img => img.Type == ImageType.Normal)
                    .FirstOrDefault().Id));
        }
    }
}