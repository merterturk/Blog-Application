using BlogApp.Data.Abstract;
using System;
using System.Threading.Tasks;

namespace BlogApp.Data.UnitOfWorks
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IArticleRepository Articles { get; } 
        ICategoryRepository Categories { get; }
        ICommentRepository Comments { get; }
        Task<int> SaveAsync();
    }
}
