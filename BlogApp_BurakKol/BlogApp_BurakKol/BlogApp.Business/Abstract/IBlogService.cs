using BlogApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Business.Abstract
{
    public interface IBlogService
    {
        List<Blog> GetAll();

        List<Blog> GetBlogsByCategory(string category, int page, int pageSize); //Bu metodu eğitim seviyelerine göre öğretmenleri listelemek için kullandım.Ayrıca sayfaları listelemek içinde parametre yolladım.

        int GetCountByCategory(string category); //Bu metot sayfalama yapmak için yazıldı.
    }
}
