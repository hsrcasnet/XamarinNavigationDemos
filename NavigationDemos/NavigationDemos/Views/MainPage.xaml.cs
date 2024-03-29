﻿using System;
using System.Diagnostics;
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
            await this.Navigation.PushAsync(new DetailPage1(), animated: true);
        }

        protected override void OnAppearing()
        {
            Debug.WriteLine("MainPage: OnAppearing");
            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            Debug.WriteLine("MainPage: OnDisappearing");
            base.OnDisappearing();
        }
    }
}
