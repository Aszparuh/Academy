namespace MvcEssentials.Web.ViewModels.Home
{
    using System;
    using System.Web.Mvc;
    using AutoMapper;
    using Infrastructure.Mapping;
    using MvcEssentials.Data.Models;

    public class NewsArticleViewModel : IMapFrom<NewsArticle>, IMapTo<NewsArticle>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Title { get; set; }

        [AllowHtml]
        public string Content { get; set; }

        public string UserName { get; set; }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<NewsArticle, NewsArticleViewModel>()
                .ForMember(x => x.UserName, opt => opt.MapFrom(x => x.Author.UserName));
        }
    }
}