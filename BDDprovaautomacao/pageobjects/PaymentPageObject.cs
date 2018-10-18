using BDDprovaautomacao.utils;
using OpenQA.Selenium;

namespace BDDprovaautomacao.pageobjects
{
    class PaymentPageObject : BasePageObject
    {
        public PaymentPageObject(IWebDriver navegador) : base(navegador)
        {

        }

        public IWebElement getPayByBankWire(IWebDriver navegador)
        {

            return navegador.FindElement(By.ClassName("bankwire"));

        }

        public IWebElement getIConfirmMyOrder(IWebDriver navegador)
        {

            return this.navegador.FindElement(By.CssSelector(".cart_navigation .button-medium"));

        }
    }
}
