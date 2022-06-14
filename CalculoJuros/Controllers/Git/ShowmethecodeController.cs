using Microsoft.AspNetCore.Mvc;

namespace CalculoJuros.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShowmethecodeController
    {
        public ShowmethecodeController()
        {
        }

        [HttpGet]
        public string RetornEnderecoProjetoGit()
        {
            return "https://github.com/programdor1805/projeto-entrevista";
        }

    }
}
