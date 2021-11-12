using BlogApp.Entities.Concrete;
using System.Collections.Generic;

namespace BlogApp.Entities.Dtos.RolesDto
{
    public class RoleListDto
    {
        public IList<Role> Roles { get; set; }
    }
}
