using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentData.Models
{
    public class StudentContext : DbContext 
    {
        public StudentContext(DbContextOptions<StudentContext> options ) : base(options)
        {

        }

        public DbSet<Student> StudentData { get; set; }
    }
}
