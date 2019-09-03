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
            buttonProceedToCheckout = new ShippingPageObject(navegador);
            marcarCheckBoxx = new ShippingPageObject(navegador);
        }

        public void MarcarCheckBox()
        {
            marcarCheckBoxx.GetCheckBox(navegador).Click();
        }

        public void ClicarBotao()
        {
            buttonProceedToCheckout.GetProceedToCheckout(navegador).Click();
        }
    }
}