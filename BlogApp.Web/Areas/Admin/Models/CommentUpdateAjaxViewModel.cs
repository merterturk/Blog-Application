﻿using BlogApp.Entities.Dtos.CommentsDto;

namespace BlogApp.Web.Areas.Admin.Models
{
    public class CommentUpdateAjaxViewModel
    {
        public CommentUpdateDto CommentUpdateDto { get; set; }
        public string CommentUpdatePartial { get; set; }
        public CommentDto CommentDto { get; set; }
    }
}
