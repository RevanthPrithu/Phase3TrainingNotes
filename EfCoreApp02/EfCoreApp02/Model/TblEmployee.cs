using System;
using System.Collections.Generic;

#nullable disable

namespace EfCoreApp02.Model
{
    public partial class TblEmployee
    {
        public int Id { get; set; }
        public string Ename { get; set; }
        public string Job { get; set; }
        public int? Salary { get; set; }
        public int? Deptid { get; set; }

        public virtual TblDepartment Dept { get; set; }
    }
}
