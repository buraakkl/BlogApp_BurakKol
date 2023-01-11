﻿using BlogApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Data.Abstract
{
    public interface ICategoryRepository : IRepository<Category>
    {
        List<Category> GetAllCategories();

        Task<List<Category>> GetAllCategoriesAsync();



    }
}
