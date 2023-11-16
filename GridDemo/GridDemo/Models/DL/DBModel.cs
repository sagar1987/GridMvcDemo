using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GridDemo.Models.DL
{
    public class DBModel : DbContext
    {
        public DBModel()
            : base("name=DBModel")
        {
        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}