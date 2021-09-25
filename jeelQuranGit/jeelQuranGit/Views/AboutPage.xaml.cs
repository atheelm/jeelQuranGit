using jeelQuranGit.Models;
using jeelQuranGit.ViewModels;
using System;
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
            System.Collections.Generic.List<Student> students = await gradeStudents;
            int grade = 1;
            await Shell.Current.GoToAsync($"{nameof(GradeChildsPage)}?grade=&students=");
        }
    }
}