using CalculoJuros.Controllers.CalculoJUros;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaxaJuros.API.Controllers;

namespace APITester
{
    [TestClass]
    public class TestController
    {
        TaxaJurosController taxaJuroscontroller;
        CalculoJurosController calculoJurosController;

        [TestInitialize]
        public void Start()
        {
            taxaJuroscontroller = new TaxaJurosController();
            calculoJurosController = new CalculoJurosController();
        }

        [TestMethod]
        public void Get_Test_Not_Null()
        {            
            var responseAPI = taxaJuroscontroller.RetornaTaxaJuros();
            Assert.IsNotNull(responseAPI);

        }


        [TestMethod]
        public void Get_Test_Calculo_Juros()
        {
            var responseAPI = calculoJurosController.RetornaCalculoJuros( 100, 5);
            Assert.IsNotNull(responseAPI);

        }
    }
}