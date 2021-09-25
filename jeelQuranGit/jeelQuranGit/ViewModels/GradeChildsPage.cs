using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static jeelQuranGit.Services.IGradeStudentsFirestore;
using Xamarin.Forms;
using jeelQuranGit.Services;
using jeelQuranGit.Models;
using System.Threading.Tasks;

namespace jeelQuranGit.ViewModels
{
    public class GradeChildsPage : ContentPage
    {
        List<Student> allStudents;
        int grade;
        public GradeChildsPage()
        {
            grade = 0;
        }
        public GradeChildsPage(int _grade, List<Student> _allStudents)
        {
            
            allStudents = _allStudents;
            grade = _grade;
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hi child" }
                }
            };
        }
        public List<Student> GradeEntry
        {
            set
            {

            }
        }

    }
}