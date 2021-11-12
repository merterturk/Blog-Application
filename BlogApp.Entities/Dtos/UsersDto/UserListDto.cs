using System;
using System.Collections.Generic;
using BlogApp.Entities.Concrete;
using BlogApp.Shared.Entities.Abstract;

namespace BlogApp.Entities.Dtos.UsersDto
{
    public class UserListDto:DtoGetBase
    {
        public IList<User> Users { get; set; }
    }
}
