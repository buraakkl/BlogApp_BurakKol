using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Entity
{
    public class Blog
    {
        public int BlogID { get; set; }
        public string? BlogName { get; set; }
        public string? BlogImage { get; set; }
        public string? BlogTitle { get; set; }
        public string? BlogContent { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DateAdded { get; set; }

        public int CategoryID { get; set; }
        public Category Category { get; set; } = null!;
        public List<BlogCategory> BlogCategories { get; set; } = null!;
    }
}
