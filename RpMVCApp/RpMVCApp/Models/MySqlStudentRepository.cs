using System.Collections.Generic;
using System.Linq;

namespace RpMVCApp.Models
{
    class MySqlStudentRepository : IStudentRepository
    {
        private List<StudentModel> students = null;
        public MySqlStudentRepository()
        {
            this.students = new List<StudentModel> {
                new StudentModel(){Id=2001,SName="Swapna",Course="IT",Fee=15000 },
                new StudentModel(){Id=2002,SName="Suresh",Course="CSE",Fee=51000 },
                new StudentModel(){Id=2003,SName="Sunil",Course="IT",Fee=5200 },
                new StudentModel(){Id=2004,SName="Swathi",Course="EEE",Fee=25000 }
            };
        }
        public List<StudentModel> GetAllStudents()
        {
            return this.students;
          
        }
        public string GetSourceInfo()
        {
            return "mysqlserver";
        }
        public StudentModel GetStudentById(int id)
        {
            return students.Single(x => x.Id == id);
        }
    }
}
