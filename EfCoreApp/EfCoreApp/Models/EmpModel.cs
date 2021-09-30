using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EfCoreApp.Models
{
    [Table("tblEmployees")]
    public class EmpModel
    {
        [Key]
        public int Id { get; set; }
        [StringLength(20)]
        public string EName { get; set; }
        [StringLength(20)]
        public string Job { get; set; }
        public double Salary { get; set; }
        

    }
}
