using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ASP.Models;

namespace ASP.DAL
{
    public class AppContext : DbContext
    {
        public AppContext() : base("AppContext")
        {

        }

        static AppContext()
        {
            Database.SetInitializer<AppContext>(new AppInitializer());
        }

        public DbSet<Accountant> Accountants { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}