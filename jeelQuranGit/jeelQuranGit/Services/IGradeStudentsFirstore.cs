using jeelQuranGit.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace jeelQuranGit.Services
{
    public interface IGradeStudentsFirestore
    {
        Task<GradeStudents> GetAllStudents(int grade);
        Task<GradeStudents> GetGradeStudentsAttendances(int grade);
        Task<GradeStudents> SetStudentAttendance(int grade, string name);
    }
}
