using MauiDemoNasa.ViewModels;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;
using System;

namespace MauiDemoNasa
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        MainPageViewModel vm;

        public MainPage(MainPageViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = viewModel;
            vm = viewModel;
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;
            CounterLabel.Text = $"Current count: {count}";

            SemanticScreenReader.Announce(CounterLabel.Text);
        }

        protected override void OnAppearing()
        {
            vm.GetData();
        }



    }
}
