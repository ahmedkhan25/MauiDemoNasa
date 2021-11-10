﻿using MauiDemoNasa.ViewModels;
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

    

        protected override void OnAppearing()
        {
            vm.GetData();
        }



    }
}
