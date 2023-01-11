using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Entity
{
    public class BlogCategory
    {
        public int BlogID { get; set; }
        public int CategoryID { get; set; } 
        public Blog Blog { get; set; } = null!;
        public Category Category { get; set; } = null!;
    }
}
