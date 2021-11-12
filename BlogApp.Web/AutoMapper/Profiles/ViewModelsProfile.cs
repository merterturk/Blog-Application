using AutoMapper;
using BlogApp.Entities.Concrete;
using BlogApp.Entities.Dtos.ArticlesDto;
using BlogApp.Web.Areas.Admin.Models;

namespace BlogApp.Web.AutoMapper.Profiles
{
    public class ViewModelsProfile : Profile
    {
        public ViewModelsProfile()
        {
            CreateMap<ArticleAddViewModel,ArticleAddDto>();
            CreateMap<ArticleUpdateDto, ArticleUpdateViewModel>().ReverseMap();
            CreateMap<ArticleRightSideBarWidgetOptions, ArticleRightSideBarWidgetOptionsViewModel>();
        }
    }
}
