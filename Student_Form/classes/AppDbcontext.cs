using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Student_Form.classes
{
    internal class AppDbcontext : DbContext
    {


        public AppDbcontext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=AALAA\\SQLEXPRESS;Initial Catalog=she2;Integrated Security=True;Connect Timeout=30;Encry" +
                "" +
                "pt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<course> Courses { get; set; }
        public DbSet<Employee> Employees { get; set; }

    }
}
