using BlogApp.Business.Abstract;
using BlogApp.Data.Abstract;
using BlogApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Business.Concrete
{
    public class BlogManager : IBlogService
    {
        private readonly IBlogRepository _blogRepository;

        public BlogManager(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public List<Blog> GetAll()
        {
            return _blogRepository.GetAll();
        }

        public List<Blog> GetBlogsByCategory(string category, int page, int pageSize)
        {
            return _blogRepository.GetBlogsByCategory(category,page, pageSize);
        }

        public int GetCountByCategory(string category)
        {
            return _blogRepository.GetCountByCategory(category);
        }
    }
}
