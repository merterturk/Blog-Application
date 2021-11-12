using BlogApp.Entities.Concrete;
using System.Collections.Generic;

namespace BlogApp.Web.Areas.Admin.Models
{
    public class UserWithRolesViewModel
    {
        public User User { get; set; }
        public IList<string> Roles { get; set; }
    }
}
