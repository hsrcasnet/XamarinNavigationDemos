using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace NavigationDemos.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new DetailPage());
        }
    }
}
