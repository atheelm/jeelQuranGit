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
        string grade;
        Grid studentsGrid;
        public GradeChildsPage()
        {
            grade = "0";
            Content = new StackLayout
            {
            };
            studentsGrid = new Grid();
        }
        private void createButtons()
        {
            foreach (Student student in allStudents)
            {
                Button btn = new Button()
                {
                    Text = student.name,
                    StyleId = student.name
                };
                //btn.Clicked 
                studentsGrid.Children.Add(btn);
            }
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

        protected override void OnAppearing()
        {
            createButtons();
            this.Content = studentsGrid;
        }
    }
}