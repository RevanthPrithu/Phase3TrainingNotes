using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Eframework2
{
    [Table("tblStudents")]
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [StringLength(20)]

        public string SName { get; set; }
        [StringLength(20)]
        public string Course { get; set; }
        public float Fee { get; set; }

    }
    public class student1dbContext:DbContext
    {
        public student1dbContext(DbContextOptions<student1dbContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    Id = 1001,
                    SName = "Kiran",
                    Course = "Trainer",
                    Fee = 3000
                });
        }
    }
}
