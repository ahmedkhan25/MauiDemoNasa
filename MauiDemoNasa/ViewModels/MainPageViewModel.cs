using MauiDemoNasa.Models;
using MauiDemoNasa.Services;
using Microsoft.Maui.Controls;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MauiDemoNasa.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class MainPageViewModel:INotifyPropertyChanged
    {
        
        public NasaPicMetadata ImageData { get; set; }
        public DateTime Date { get; set; }
        private IAPIService service { get; set; }

        public MainPageViewModel(IAPIService apiService)
        {
            service = apiService;
            Date = DateTime.Now;

            TodayClickedCommand = new Command(
            execute: async() =>
            {
                Date = DateTime.Now;
                ImageData =  await service.GetData(Date);
            });

            GoBackOneDayCommand = new Command(
            execute: async () =>
            {
                Date = Date.AddDays(-1);
                ImageData = await service.GetData(Date);
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public async void GetData()
        {
            var x  = await service.GetData(Date);
            ImageData = x;
        }

        public Command TodayClickedCommand { private set; get; }
        public Command GoBackOneDayCommand { private set; get; }

    }

    
}
