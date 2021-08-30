using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automação_Selenium.Pages
{
    class Pesquisa
    {
        private IWebDriver driver;

        public Pesquisa(IWebDriver driver)
        {
            this.driver = driver;
        }

        private WebDriverWait Esperar()
        {
            return new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        }

        private By ContadorDeProduto()
        {
            return By.ClassName("product-count");
        }

        public Boolean ValidarResultadoDaPesquisa()
        {
            if (Esperar().Until(ExpectedConditions.ElementIsVisible(ContadorDeProduto())).Displayed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
