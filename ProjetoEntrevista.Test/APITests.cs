using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaxaJuros.API.Controllers;

namespace ProjetoEntrevista.Test
{
    [TestClass]
    public class ApiTests
    {
        TaxaJurosController controller;

        [TestInitialize]
        public void Start()
        {
            controller = new TaxaJurosController();
        }


        [TestMethod]
        public async Task Get_Test_OK()
        {

            var responseAPI = controller.RetornaTaxaJuros();
            Assert.IsInstanceOfType(responseAPI, typeof(OkResult));

        }
    }
}