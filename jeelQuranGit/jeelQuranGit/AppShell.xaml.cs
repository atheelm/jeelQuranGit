using jeelQuranGit.ViewModels;
using jeelQuranGit.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace jeelQuranGit
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(GradeChildsPage), typeof(GradeChildsPage));
        }

    }
}
