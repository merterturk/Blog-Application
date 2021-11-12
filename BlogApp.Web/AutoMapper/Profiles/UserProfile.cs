using AutoMapper;
using BlogApp.Entities.ComplexTypes;
using BlogApp.Entities.Concrete;
using BlogApp.Entities.Dtos.UsersDto;
using BlogApp.Web.Helpers.Abstract;

namespace BlogApp.Web.AutoMapper.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile(IImageHelper imageHelper)
        {
            CreateMap<UserAddDto, User>().ForMember(dest=>dest.Picture,opt=>
                opt.MapFrom(x=> imageHelper.Upload(x.UserName,x.PictureFile,PictureType.User,null)));
            CreateMap<User, UserUpdateDto>();
            CreateMap<UserUpdateDto, User>();
        }
    }
}
