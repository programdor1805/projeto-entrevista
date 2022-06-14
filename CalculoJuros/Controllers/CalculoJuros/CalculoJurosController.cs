using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CalculoJuros.Controllers.CalculoJUros
{
    [ApiController]
    [Route("[controller]")]
    public class CalculoJurosController
    {
        public CalculoJurosController()
        {
        }

        [HttpGet("{valorInicial}/{meses}")]
        public async Task<string> RetornaCalculoJuros(double valorInicial, int meses)
        {
          
                var valorFinal = string.Empty;
                HttpClientHandler clientHandler = new HttpClientHandler();
                clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

                using (HttpClient client = new HttpClient(clientHandler))
                {
                    client.BaseAddress = new Uri("https://localhost:8081/TaxaJuros");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                    try
                    {
                        var responde = await client.GetAsync("TaxaJuros");
                        var content = await responde.Content.ReadAsStringAsync();
                        var jsonResult = JsonConvert.DeserializeObject(content).ToString();
                        double porcentagem = double.Parse(jsonResult);
                        var resultado = Math.Pow(1 + porcentagem, Convert.ToDouble(meses)) * valorInicial;
                        valorFinal = resultado.ToString("F");
                    }
                    catch (Exception ex)
                    {
                        return ex.Message;

                    }

                }

                return valorFinal;
            }
          
    }
}
