using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static jeelQuranGit.Services.IGradeStudentsFirestore;
using Xamarin.Forms;
using jeelQuranGit.Services;
using jeelQuranGit.Models;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace jeelQuranGit.ViewModels
{
    [QueryProperty("StudentsEntry", "Students")]
    [QueryProperty("GradeEntry", "Grade")]
    public class GradeChildsPage : ContentPage
    {
        List<Student> allStudents;
        string studentsName;
        string grade;
        public GradeChildsPage()
        {
            grade = "0";
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hi boy" }
                }
            };
        }
        public GradeChildsPage(int _grade, List<Student> _allStudents)
        {
            
            //allStudents = _allStudents;
            //grade = _grade;
        }
        public string GradeEntry
        {
            set
            {
                grade = Uri.UnescapeDataString(value);
            }
        }
        public string StudentsEntry
        {
            set
            {
                //studentsName = Uri.UnescapeDataString(value);
                allStudents = JsonConvert.DeserializeObject<List<Student>>(value);
                //allStudents = data;
            }
        }
    }
}