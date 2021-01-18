using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NET_Core_MVC_Basic.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_Core_MVC_Basic.Database
{
    public class ApplicationDdContext : DbContext
    {
        public ApplicationDdContext(DbContextOptions<ApplicationDdContext> options) : base (options)
        {

        }

        public DbSet<CategoryModel> Category { get; set; }


    }
}
