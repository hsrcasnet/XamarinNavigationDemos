using System;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavigationDemos.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage1 : ContentPage
    {
        public DetailPage1()
        {
            this.InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new DetailPage2());
        }

        protected override void OnAppearing()
        {
            Debug.WriteLine("DetailPage1: OnAppearing");
            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            Debug.WriteLine("DetailPage1: OnDisappearing");
            base.OnDisappearing();
        }
    }
}