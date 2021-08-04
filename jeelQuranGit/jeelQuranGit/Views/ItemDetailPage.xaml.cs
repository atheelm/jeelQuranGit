using jeelQuranGit.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace jeelQuranGit.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}