using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static jeelQuranGit.Services.GradeStudentsFirestore;
using Xamarin.Forms;
using jeelQuranGit.Services;

namespace jeelQuranGit.ViewModels
{
    public class GradeChildsPage : ContentPage
    {
        public GradeChildsPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Welcome to Xamarin.Forms!" }
                }
            };
        }
        public GradeChildsPage(GradeStudentsFirestore gradeFirestore)
        {
            var gradeStudents = gradeFirestore.GetGradeStudents(1);
            if (gradeStudents != null)
            {

            }
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Welcome to Xamarin.Forms!" }
                }
            };
        }

    }
}