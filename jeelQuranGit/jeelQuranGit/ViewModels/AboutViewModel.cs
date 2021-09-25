using jeelQuranGit.Models;
using jeelQuranGit.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace jeelQuranGit.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "Grades";
            OpenGradeCommand = new Command(async () => await Shell.Current.GoToAsync($"{nameof(GradeChildsPage)}"));
        }

        public ICommand OpenGradeCommand {
            //Task<List<Student>> gradeStudents =  DependencyService.Get <IGradeStudentsFirestore>().GetAllStudents();
        get; }
    }
}