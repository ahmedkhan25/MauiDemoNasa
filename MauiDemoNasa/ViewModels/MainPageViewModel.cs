using MauiDemoNasa.Models;
using MauiDemoNasa.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiDemoNasa.ViewModels
{
   
    public class MainPageViewModel 
    {
        
        public NasaPicMetadata data { get; set; }
        public MainPageViewModel(IAPIService apiService)
        {
            
        }

       
        
    }

    
}
