using Assignment.Models.ITIModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.DatabaseContext
{
    internal class ITIDbContext: DbContext
    {
        public ITIDbContext():base()
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = ITIEF; Trusted_Connection = true;TrustServerCertificate = true");
        }

        

        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<stud_Course> stud_Courses { get; set; }
        public DbSet<Course_Instructor> Course_Instructors { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course_Instructor>().HasKey(CI => new { CI.Inst_Id, CI.Course_Id });
            modelBuilder.Entity<stud_Course>().HasKey(SC => new { SC.Course_Id, SC.stud_Id });
        }


    }
}
