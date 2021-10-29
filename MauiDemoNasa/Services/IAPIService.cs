using MauiDemoNasa.Models;
using System.Threading.Tasks;

namespace MauiDemoNasa.Services
{
    public interface IAPIService
    {
        Task<NasaPicMetadata> GetData();

    }
}