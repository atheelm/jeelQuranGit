using System;
using System.Collections.Generic;
using System.Text;

namespace jeelQuranGit.Models
{
    public class GradeStudents
    {
        int grade;
        List<Student> allStudents;
        public GradeStudents(int _grade)
        {
            grade = _grade;
            allStudents = new List<Student>();
        }
        public void addStudent(Student student)
        {
            allStudents.Add(student);
        }
        public Student getStudent()
        {
            return allStudents[0];
        }
    }
}
