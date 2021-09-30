using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Eframework
{
    [Table("tblEmployees")]
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [StringLength(20)]
        public string EName { get; set; }
        [StringLength(20)]
        public string Job { get; set; }
        public double Salary { get; set; }
    }

    public class revudbContext : DbContext
    {
        public revudbContext(DbContextOptions<revudbContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }

    
}
