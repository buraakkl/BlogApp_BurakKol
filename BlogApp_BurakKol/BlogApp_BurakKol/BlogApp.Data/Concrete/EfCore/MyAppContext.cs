using BlogApp.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Data.Concrete.EfCore
{
    public class MyAppContext : DbContext
    {
        public MyAppContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Blog> Blog { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<BlogCategory> BlogCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<BlogCategory>()
                .HasKey(bc => new
                {
                    bc.BlogID,
                    bc.CategoryID
                });

            modelBuilder
                .Entity<Category>()
                .HasData(
                new Category { CategoryID = 1, CategoryName = "Music", IsDeleted = false },
                new Category { CategoryID = 2, CategoryName = "Game", IsDeleted = false },
                new Category { CategoryID = 3, CategoryName = "Books", IsDeleted = false },
                new Category { CategoryID = 4, CategoryName = "Food", IsDeleted = false },
                new Category { CategoryID = 5, CategoryName = "Sport", IsDeleted = false }
                );

            modelBuilder
                .Entity<Blog>()
                .HasData(
                new Blog { BlogID = 1,  BlogImage = "1", BlogTitle = "Music History", BlogContent = " lorem ipsum dolor.", BlogName = "Jazz instruments", DateAdded = DateTime.Now, IsDeleted = false, CategoryID = 3 },
                new Blog { BlogID = 2, BlogImage = "2", BlogTitle = "Game History", BlogContent = " lorem ipsum dolor.", BlogName = "Fps Games", DateAdded = DateTime.Now, IsDeleted = false, CategoryID=1 }
                );

            modelBuilder
                .Entity<BlogCategory>()
                .HasData(
                new BlogCategory() { BlogID = 1, CategoryID = 1 },
                new BlogCategory() { BlogID = 2, CategoryID = 2 }
                );



        }
    }
}
