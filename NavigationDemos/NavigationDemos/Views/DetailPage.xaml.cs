using System;
using Xamarin.Forms;

namespace NavigationDemos.Views
{
    public partial class DetailPage : ContentPage
    {
        public DetailPage()
        {
            this.InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
             await this.Navigation.PopAsync();
        }
    }
}
