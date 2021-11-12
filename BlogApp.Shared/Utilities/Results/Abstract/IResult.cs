using BlogApp.Shared.Utilities.Results.ComplexTypes;
using System;
using System.Collections.Generic;
using BlogApp.Shared.Entities.Concrete;

namespace BlogApp.Shared.Utilities.Results.Abstract
{
    public interface IResult
    {
        public ResultStatus ResultStatus { get; } 
        public string Message { get; }
        public Exception Exception { get; }
        public IEnumerable<ValidationError> ValidationErrors { get; set; }
    }
}
