using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace NavigationDemos.Views
{
    public partial class DetailPage2 : ContentPage
    {
        public DetailPage2()
        {
            this.InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            await this.Navigation.PopAsync();
        }

        protected override void OnAppearing()
        {
            Debug.WriteLine("DetailPage2: OnAppearing");
            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            Debug.WriteLine("DetailPage2: OnDisappearing");
            base.OnDisappearing();
        }
    }
}
