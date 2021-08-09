using System;
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

        public ICommand OpenGradeCommand { get; }
    }
}