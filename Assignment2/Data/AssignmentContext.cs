using Assignment2.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment2.Data
{
    public class Assignment2Context : DbContext
    {
        public Assignment2Context(DbContextOptions<Assignment2Context> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    StudentId = 1,
                    Name = "Diya Patel",
                    Major = "Information Technology"
                },
                new Student
                {
                    StudentId = 2,
                    Name = "John Smith",
                    Major = "Cybersecurity"
                },
                new Student
                {
                    StudentId = 3,
                    Name = "Sarah Jones",
                    Major = "Data Analytics"
                }
            );

            modelBuilder.Entity<Course>().HasData(
                new Course
                {
                    CourseId = 1,
                    CourseName = "Web Development",
                    Credits = 3
                },
                new Course
                {
                    CourseId = 2,
                    CourseName = "Database Management",
                    Credits = 3
                },
                new Course
                {
                    CourseId = 3,
                    CourseName = "Data Analytics",
                    Credits = 3
                }
            );
        }
    }
}
