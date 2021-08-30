using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automação_Selenium.Pages
{
    class Home
    {
        private IWebDriver driver; 

        public Home(IWebDriver driver)
        {
            this.driver = driver;
        }
        private IWebElement Busca()
        {
            return driver.FindElement(By.Id("search_query_top"));
        }

        private IWebElement Pesquisar()
        {
            return driver.FindElement(By.CssSelector("button[name=submit_search]"));
        }

        public void AcessarSite(string url)
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
        }
              
        public void Consultar(string item)
        {
            //preencher campo de pesquisa
            Busca().SendKeys(item);

            //clicar no botão Lupa para pesquisar
            Pesquisar().Click();
        }
    }
}
