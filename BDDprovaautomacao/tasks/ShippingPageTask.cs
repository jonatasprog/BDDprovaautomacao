using BDDprovaautomacao.pageobjects;
using OpenQA.Selenium;

namespace BDDprovaautomacao.tasks
{
    class ShippingPageTask
    {
        private IWebDriver navegador;
        public ShippingPageObject buttonProceedToCheckout;
        public ShippingPageObject marcarCheckBoxx;

        public ShippingPageTask(IWebDriver navegador)
        {
            this.navegador = navegador;
            this.buttonProceedToCheckout = new ShippingPageObject(this.navegador);
            this.marcarCheckBoxx = new ShippingPageObject(this.navegador);
        }

        public void marcarCheckBox()
        {

            this.marcarCheckBoxx.getCheckBox(navegador).Click();


        }

        public void clicarBotao()
        {
            this.buttonProceedToCheckout.getProceedToCheckout(navegador).Click();
        }
    }
}
