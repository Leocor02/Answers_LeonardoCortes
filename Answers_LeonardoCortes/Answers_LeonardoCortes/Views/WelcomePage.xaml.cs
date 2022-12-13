using Answers_LeonardoCortes.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Answers_LeonardoCortes.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WelcomePage : ContentPage
    {
        UserViewModel vm;
        public WelcomePage()
        {
            InitializeComponent();
        }

        private async void BtnIngreso_Clicked(object sender, EventArgs e)
        {
                try
                {
                    GlobalObjects.GlobalUser = await vm.GetUserData(3);
                }
                catch (Exception ex)
                {
                    await DisplayAlert("Error", ex.Message, "OK");
                    return;
                }

                await Navigation.PushAsync(new AskPage());
        }
    }
}