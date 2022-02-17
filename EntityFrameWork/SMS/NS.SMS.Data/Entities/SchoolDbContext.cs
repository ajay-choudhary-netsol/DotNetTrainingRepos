using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace NS.SMS.Data.Entities
{
    public class SchoolDbContext: DbContext
    {
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students{ get; set; }
        public DbSet<Course> Course { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-0060IK5H\SQLEXPRESS; Database=SchoolDBCodeFirst;Trusted_Connection = True;");
        }
    }
}
