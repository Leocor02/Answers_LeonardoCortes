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
	public partial class AskPage : ContentPage
	{
		UserViewModel vm;
		public AskPage ()
		{
			InitializeComponent ();

			BindingContext = vm = new UserViewModel();
		}

		//private async void LoadQuestion()
		//{
		//	//LstQuestions.ItemsSource = await vm.AddNewQuestion();
		//}
	}
}