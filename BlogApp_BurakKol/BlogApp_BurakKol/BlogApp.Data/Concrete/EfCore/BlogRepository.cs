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
    public class BlogRepository : GenericRepository<Blog>, IBlogRepository
    {

        public BlogRepository(MyAppContext _context) : base(_context)
        {

        }
        private MyAppContext Context
        {
            get { return _dbContext as MyAppContext; }
        }

        public List<Blog> GetAll()
        {
            return Context
                .Blog
                .Where(c => c.IsDeleted== false)
                .Include(b => b)
                .ToList();
        }

        public List<Blog> GetBlogsByCategory(string category, int page, int pageSize)
        {
            var blogs = Context
                           .Blog
                           .AsQueryable();
            if (!string.IsNullOrEmpty(category))
            {
                blogs = blogs
                    .Include(e => e.Category)
                    .Where(e => e.Category.CategoryName == category);
            }

            return blogs.Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }

        public int GetCountByCategory(string category)
        {
            var blogs = Context.Blog.AsQueryable();
            if (!string.IsNullOrEmpty(category))
            {
                blogs = blogs
                    .Where(p => p.IsDeleted == false)
                    .Include(p => p.Category);


            };

            return blogs.Count();
        }
    }
}


    

