using BlogApp.Business.Abstract;
using BlogApp.Entity;
using Microsoft.AspNetCore.Mvc;
using Web.UI.ViewModels;

namespace Web.UI.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;

        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IActionResult Index()
        {
            return View();
        }

        //public IActionResult GetListBlog()
        //{
        //    var getListBlog = _blogService.GetAll();
        //    BlogViewModel viewModel = new BlogViewModel();
        //    viewModel.Blogs = getListBlog;
        //    return View(viewModel);
        //}

        [HttpGet]
        public IActionResult List(string category, int page = 1) 
        {
            const int pageSize = 3; 
            List<Blog> blogs = _blogService.GetBlogsByCategory(category, page, pageSize);

            PageInfo pageInfo = new PageInfo()
            {
                TotalItems = _blogService.GetCountByCategory(category),
                CurrentPage = page,
                ItemsPerPage = pageSize,
                CurrentCategory = category
            };

            BlogViewModel BlogViewModel = new BlogViewModel()
            {
                Blogs = blogs,
                PageInfo = pageInfo
            };
            return View(BlogViewModel);
        }


    }
}
