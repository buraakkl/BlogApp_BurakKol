using BlogApp.Business.Abstract;
using BlogApp.Entity;
using Microsoft.AspNetCore.Mvc;

namespace Web.UI.Components
{
    public class CategorizedBlogsViewComponent : ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public CategorizedBlogsViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            if (RouteData.Values["category"] != null)
            {
                ViewBag.SelectedCategories = RouteData.Values["category"];
            }

            List<Category> categories = _categoryService.GetAllCategories();
            return View(categories);
        }




    }
}
