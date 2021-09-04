using jeelQuranGit.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace jeelQuranGit.Services
{
    public interface IGradeStudentsFirestore
    {
        Task<GradeStudents> GetGradeStudents(int grade);
    }
}
