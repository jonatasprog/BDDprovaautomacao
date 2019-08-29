using BDDprovaautomacao.pageobjects;
using OpenQA.Selenium;

namespace BDDprovaautomacao.tasks
{
    class AddressPageTask
    {
        private IWebDriver navegador;
        public AddressPageObject buttonProceedToCheckout;

        public AddressPageTask(IWebDriver navegador)
        {
            this.navegador = navegador;
            this.buttonProceedToCheckout = new AddressPageObject(this.navegador);
        }

        public void ClicarBotao()
        {
            this.buttonProceedToCheckout.GetProceedToCheckout().Click();
        }
    }
}