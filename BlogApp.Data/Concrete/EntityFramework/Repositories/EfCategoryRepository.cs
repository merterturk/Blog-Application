using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogApp.Data.Abstract;
using BlogApp.Data.Concrete.EntityFramework.Contexts;
using BlogApp.Entities.Concrete;
using BlogApp.Shared.Data.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.Data.Concrete.EntityFramework.Repositories
{
    public class EfCategoryRepository : EfEntityRepositoryBase<Category>, ICategoryRepository
    {
        public EfCategoryRepository(DbContext context) : base(context)
        {
        }

        public async Task<Category> GetById(int categoryId)
        {
            return await BlogAppContext.Categories.SingleOrDefaultAsync(c => c.Id == categoryId);
        }
        private BlogAppContext BlogAppContext{get{return _context as BlogAppContext;}}
    }
}
