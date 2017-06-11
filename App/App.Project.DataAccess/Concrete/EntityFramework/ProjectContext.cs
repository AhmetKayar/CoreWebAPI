using App.Project.Entites.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Project.DataAccess.Concrete.EntityFramework
{
    public class ProjectContext : DbContext
    {
      
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
