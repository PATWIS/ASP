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
        public DbSet<Accountant> Accountant { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Employee> Employee { get; set; }
    }
}