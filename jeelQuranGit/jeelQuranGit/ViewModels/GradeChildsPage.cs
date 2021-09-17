using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static jeelQuranGit.Services.IGradeStudentsFirestore;
using Xamarin.Forms;
using jeelQuranGit.Services;

namespace jeelQuranGit.ViewModels
{
    public class GradeChildsPage : ContentPage
    {
        //IGradeStudentsFirestore gradeFirestore;
        public GradeChildsPage()
        {
            //var gradeStudents = gradeFirestore.GetGradeStudents(1);
            //FirebaseApp.initializeApp();
            var gradeStudents =  DependencyService.Get < IGradeStudentsFirestore>().GetAlltudents(1);
            if (gradeStudents != null)
            {
                gradeStudents.Start();
                gradeStudents.Wait();
                gradeStudents.Result.ToString();
            }
            else
            {

            }
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hi child" }
                }
            };
        }

    }
}