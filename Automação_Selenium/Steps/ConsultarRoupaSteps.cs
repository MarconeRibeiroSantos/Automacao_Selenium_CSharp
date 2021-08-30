using Automação_Selenium.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Automação_Selenium.Steps
{
    [Binding]
    public class ConsultarRoupaSteps
    {
        string url = "http://automationpractice.com/";
        IWebDriver driver;
        Pesquisa pesquisa;
        Home home;

        [Given(@"eu acesse o site My store")]
        public void DadoEuAcesseOSiteMyStore()
        {
            //Iniciando as classes
            driver = Util.Util.IniciarDriver();
            home = new Home(driver);
            pesquisa = new Pesquisa(driver);

            //Acessar o site
            home.AcessarSite(url);
        }

        [When(@"eu desejar procurar uma camiseta")]
        public void QuandoEuDesejarProcurarUmaCamiseta()
        {
            //Consultar item
            home.Consultar("dresses");
        }

        [Then(@"o site me retorna as camisetas disponíveis")]
        public void EntaoOSiteMeRetornaAsCamisetasDisponiveis()
        {
            //Retorno de Item
            pesquisa.ValidarResultadoDaPesquisa();
            Util.Util.FinalizarDriver(driver);
        }
    }
}
