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
            buttonProceedToCheckout = new AddressPageObject(this.navegador);
        }

        public void ClicarBotao()
        {
            buttonProceedToCheckout.GetProceedToCheckout().Click();
        }
    }
}