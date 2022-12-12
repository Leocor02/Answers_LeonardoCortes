using Answers_LeonardoCortes.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Answers_LeonardoCortes.Views
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