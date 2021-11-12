using BlogApp.Entities.Concrete;
using BlogApp.Shared.Entities.Abstract;

namespace BlogApp.Entities.Dtos.ArticlesDto
{
    public class ArticleDto : DtoGetBase
    {
        public Article Article { get; set; }
    }
}
