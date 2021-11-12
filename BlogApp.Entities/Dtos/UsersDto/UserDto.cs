using BlogApp.Entities.Concrete;
using BlogApp.Shared.Entities.Abstract;

namespace BlogApp.Entities.Dtos.UsersDto
{
    public class UserDto:DtoGetBase
    {
        public User User { get; set; }
    }
}
