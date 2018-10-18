using BDDprovaautomacao.pageobjects;
using OpenQA.Selenium;

namespace BDDprovaautomacao.tasks
{
    class PaginaAdressTask
    {
        private IWebDriver navegador;
        public PaginaAdressObject buttonProceedToCheckout;

        public PaginaAdressTask(IWebDriver navegador)
        {
            this.navegador = navegador;
            this.buttonProceedToCheckout = new PaginaAdressObject(this.navegador);
        }

        public void clicarBotao()
        {
            this.buttonProceedToCheckout.getProceedToCheckout().Click();
        }
    }
}
