using System;
using Xamarin.Forms;

namespace NavigationDemos.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new DetailPage());
        }
    }
}
