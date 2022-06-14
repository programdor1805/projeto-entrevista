using Microsoft.AspNetCore.Mvc;

namespace CalculoJuros.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GitController
    {
        public GitController()
        {
        }

        [HttpGet]
        public string RetornEnderecoProjetoGit()
        {
            return "Meu Git";
        }

    }
}
