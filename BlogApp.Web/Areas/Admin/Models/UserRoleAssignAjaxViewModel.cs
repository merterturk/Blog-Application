using BlogApp.Entities.Dtos.RolesDto;
using BlogApp.Entities.Dtos.UsersDto;

namespace BlogApp.Web.Areas.Admin.Models
{
    public class UserRoleAssignAjaxViewModel
    {
        public UserRoleAssignDto UserRoleAssignDto { get; set; }
        public string RoleAssignPartial { get; set; }
        public UserDto UserDto { get; set; }
    }
}
