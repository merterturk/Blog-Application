using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogApp.Entities.Concrete;
using BlogApp.Shared.Entities.Abstract;

namespace BlogApp.Entities.Dtos.ArticlesDto
{
    public class ArticleListDto : DtoGetBase
    {
        public IList<Article> Articles { get; set; }
        public int? CategoryId { get; set; }
    }
}
