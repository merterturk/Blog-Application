using BlogApp.Entities.Concrete;
using BlogApp.Entities.Dtos.ArticlesDto;

namespace BlogApp.Web.Models
{
    public class ArticleDetailRightSideBarViewModel
    {
        public string Header { get; set; }
        public ArticleListDto ArticleListDto { get; set; }
        public User User { get; set; }
    }
}
