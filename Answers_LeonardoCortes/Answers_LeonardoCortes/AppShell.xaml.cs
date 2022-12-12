using Answers_LeonardoCortes.ViewModels;
using Answers_LeonardoCortes.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Answers_LeonardoCortes
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
