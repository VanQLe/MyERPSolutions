using Microsoft.EntityFrameworkCore;
using MyERPSolutions.PrideTek.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyERPSolutions.PrideTek.Dao
{
    public class MyERPSolutionsDataContext: DbContext
    {
        public MyERPSolutionsDataContext()
        {
        }

        public MyERPSolutionsDataContext(DbContextOptions<MyERPSolutionsDataContext> options)
            : base(options)
        {
            this.ChangeTracker.LazyLoadingEnabled = false;
        }

        public virtual DbSet<User> User { get; set; }
    }
}
