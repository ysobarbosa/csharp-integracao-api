using Refit;
using System;
using System.Threading.Tasks;

namespace Exemplorefit
{
    public class Program
    {
        static async Task Main(string[] args)
        {
           try
            {
                var cepClient = RestService.For<ICepApiService>("http://viacep.com.br");
                Console.WriteLine("Informe seu cep: ");

                string cepInformado = Console.ReadLine().ToString();
                Console.WriteLine($"Consultando informações do CEP: {cepInformado}");

                var adress = await cepClient.GetAddressAsync(cepInformado);
                 
                Console.WriteLine($"\nLogradouro: {adress.Logradouro}, \nBairro: {adress.Bairro}, \nCidade: {adress.Localidade}" +
                    $"\nEstado:{adress.UF}");
                Console.ReadKey();

            } catch (Exception e)
            {
                Console.WriteLine("Erro na consulta de cep: " + e.Message);
            } 
        }
    }
}
