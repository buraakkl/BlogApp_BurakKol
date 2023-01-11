using BlogApp.Data.Abstract;
using BlogApp.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Data.Concrete.EfCore
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(MyAppContext dbContext) : base(dbContext)
        {

        }

        private MyAppContext context
        {
            get
            {
                return context as MyAppContext;
            }
        }

        public List<Category> GetAllCategories()
        {
            return
                context
                .Categories
                .ToList();
        }

        public async Task<List<Category>> GetAllCategoriesAsync()
        {
            return await context.Categories.ToListAsync();
        }
    }
}
