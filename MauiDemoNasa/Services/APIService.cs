using MauiDemoNasa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;


namespace MauiDemoNasa.Services
{
    public class APIService : IAPIService
    {
        HttpClient client;
        NasaPicMetadata data;

        public const string NASA_APOD_API_URL = "https://api.nasa.gov/planetary/apod?api_key=";
        public const string NASA_APOD_API_KEY = "PXJSbHNMcL740LoeNKhj35VqHc8cqYe5Xn9BUS4e"; //Ahmed Generated on 10/28/2021 from https://api.nasa.gov/

        public APIService()
        {
            client = new HttpClient();
             
       }

        public async Task<NasaPicMetadata> GetData(DateTime date)
        {
            var apiURL = NASA_APOD_API_URL + NASA_APOD_API_KEY+ "&date=" +date.ToString("yyyy-MM-dd");
            var x = await client.GetFromJsonAsync<NasaPicMetadata>(apiURL);
            return x;

        }

    }
}
