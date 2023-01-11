using BlogApp.Data.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Data.Concrete.EfCore
{
    public class GenericRepository<TEntity> : IRepository<TEntity>
         where TEntity : class
    {
        protected readonly DbContext _dbContext;

        public GenericRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
