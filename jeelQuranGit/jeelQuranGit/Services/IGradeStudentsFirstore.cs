using jeelQuranGit.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace jeelQuranGit.Services
{
    public interface IGradeStudentsFirestore
    {
        
        Task<List<Student>> GetAllStudents(); //Return all students info from firestore (name + grade + phone) return List<Student>

        Task<List<Tuple<String,bool>>> GetGradeStudentsAttendances(int grade); //Return grade all students attendances returns List<Tuple<name,attendance>>
        
        Task<bool> SetStudentAttendance(int grade, string name); //Set student attendance in firestore. return success / not
    }
}
