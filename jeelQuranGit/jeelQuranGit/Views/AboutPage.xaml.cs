using jeelQuranGit.Models;
using jeelQuranGit.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace jeelQuranGit.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }
        async void OnButtonClicked(object sender, EventArgs args)
        {
            Task<System.Collections.Generic.List<Student>> gradeStudents = DependencyService.Get<Services.IGradeStudentsFirestore>().GetAllStudents();
            List<Student> studentsList = await gradeStudents;
            List<Student> currGradeList = new List<Student>();
            string currGrade = ((Button)sender).BindingContext as string;
            foreach (Student student in studentsList)
            {
                if (student.grade.ToString() == currGrade)
                {
                    currGradeList.Add(student);
                }
            }

            
            var jsonStudents = JsonConvert.SerializeObject(currGradeList);
            await Shell.Current.GoToAsync($"{nameof(GradeChildsPage)}?Students={jsonStudents}&Grade={currGrade}");
        }
    }
}