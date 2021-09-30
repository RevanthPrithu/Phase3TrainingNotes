using System;
using System.Collections.Generic;

#nullable disable

namespace WebAppApi02.Model
{
    public partial class TblDepartment
    {
        public TblDepartment()
        {
            TblEmployees = new HashSet<TblEmployee>();
        }

        public int Id { get; set; }
        public string Dname { get; set; }
        public string Location { get; set; }

        public virtual ICollection<TblEmployee> TblEmployees { get; set; }
    }
}
