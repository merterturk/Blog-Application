using BlogApp.Entities.Concrete;
using BlogApp.Shared.Data.Abstract;

namespace BlogApp.Data.Abstract
{
    public interface IArticleRepository : IEntityRepository<Article>
    {
    }
}
