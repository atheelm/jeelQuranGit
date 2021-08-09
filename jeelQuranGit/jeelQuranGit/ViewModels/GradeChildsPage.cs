using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

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

    }
}