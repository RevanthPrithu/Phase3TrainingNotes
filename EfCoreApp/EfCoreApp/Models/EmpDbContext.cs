using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EfCoreApp.Models
{
    
    
        public static class ModelBuilderExtensions
        {
            public static void SeedEmployee(this ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<EmpModel>().HasData(
                    new EmpModel { Id = 1001, EName = "Shivani", Job = "Manager", Salary = 10000 },
                    new EmpModel { Id = 1002, EName = "Yuvaraj", Job = "Developer", Salary = 9000 },
                    new EmpModel { Id = 1003, EName = "Kiran", Job = "Trainer", Salary = 85000 }
                    );
            }
        }
        public class EmpDbContext : DbContext
        {
            public EmpDbContext(DbContextOptions<EmpDbContext> options) : base(options)
            {
            }
            public DbSet<EmpModel> Employees { get; set; }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);
                modelBuilder.SeedEmployee();
            }
        }
    
}
