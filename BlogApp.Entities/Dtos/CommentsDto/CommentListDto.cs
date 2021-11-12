using System.Collections.Generic;
using BlogApp.Entities.Concrete;

namespace BlogApp.Entities.Dtos.CommentsDto
{
    public class CommentListDto
    {
        public IList<Comment> Comments { get; set; }
    }
}
