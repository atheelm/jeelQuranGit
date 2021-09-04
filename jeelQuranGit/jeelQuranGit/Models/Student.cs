using System;
using System.Collections.Generic;
using System.Text;

namespace jeelQuranGit.Models
{
    public class Student
    {
        int grade;
        string name;
        string phone;
    public
        Student ()
        {
            grade = 0;
            name = "None";
            phone = "None";
        }
    public Student(string _grade, string _name, string _phone)
        {
          
            name = _name;
        }
        public Student (int _grade, string _name ,string _phone)
        {
            grade = _grade;
            name = _name;
        }

    }
}
