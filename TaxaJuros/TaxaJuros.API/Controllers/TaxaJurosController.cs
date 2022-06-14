using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace TaxaJuros.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaxaJurosController
    {
        Model.TaxaJuro obj;
        public TaxaJurosController()
        {
            obj = new Model.TaxaJuro();
        }

        [HttpGet]
        public string RetornaTaxaJuros() 
        {          
            return obj.porcentagem = "0,01";
        }

    }
}
