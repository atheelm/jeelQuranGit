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
        async void OnButton1Clicked(object sender, EventArgs args)
        {
            Task<System.Collections.Generic.List<Student>> gradeStudents = DependencyService.Get<Services.IGradeStudentsFirestore>().GetAllStudents();
            List<Student> studentsList = await gradeStudents;
            string firstGrade = "1";
            var jsonStudents = JsonConvert.SerializeObject(studentsList);
            await Shell.Current.GoToAsync($"{nameof(GradeChildsPage)}?Students={jsonStudents}&Grade={firstGrade}");
        }
    }
}