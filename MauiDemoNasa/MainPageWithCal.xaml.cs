using MauiDemoNasa.ViewModels;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;
using System;

namespace MauiDemoNasa
{
    public partial class MainPageWithCal : ContentPage
    {
        int count = 0;
        MainPageViewModel vm;

        public MainPageWithCal(MainPageViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = viewModel;
            vm = viewModel;
        }

    

        protected override void OnAppearing()
        {
            vm.GetData();
        }
        private void Handle_DateSelected(object sender, DateChangedEventArgs e)
        {
           
            vm.GetData();
        }


    }
}
