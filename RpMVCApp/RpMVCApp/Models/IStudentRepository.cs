using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RpMVCApp.Models
{
    public interface IStudentRepository
    {
        List<StudentModel> GetAllStudents();
        StudentModel GetStudentById(int id);
        string GetSourceInfo();
    }
}
