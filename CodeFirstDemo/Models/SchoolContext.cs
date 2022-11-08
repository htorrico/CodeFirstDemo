using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirstDemo.Models
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("name = MyContextDB") { }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }

        public DbSet<Enrollment> Enrollments { get; set; }




    }
}