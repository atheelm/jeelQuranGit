using System;
using System.Collections.Generic;
using System.Text;

namespace jeelQuranGit.Models
{
    public class Student
    {
        public int grade;
        public string name;
        public string phone;
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
            phone = _phone;
            grade = Int32.Parse(_grade);
        }
        public Student (int _grade, string _name ,string _phone)
        {
            grade = _grade;
            name = _name;
            phone = _phone;
        }

    }
}
