using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Entity
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public bool IsDeleted { get; set; }

        public List<BlogCategory> BlogCategories { get; set; } = null!;
    }
}
