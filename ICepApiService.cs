using Refit;
using System.Threading.Tasks;

namespace Exemplorefit
{
    public interface ICepApiService
    {
        [Get("/ws/{cep}/json/")]
        Task<CepResponse> GetAddressAsync(string cep);
    }
}
