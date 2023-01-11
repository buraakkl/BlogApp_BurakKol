using BlogApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Business.Abstract
{
    public interface ICategoryService 
    {
        List<Category> GetAllCategories();
        Task<List<Category>> GetAllCategoriesAsync();
    }
}
