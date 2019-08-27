using BDDprovaautomacao.utils;
using OpenQA.Selenium;

namespace BDDprovaautomacao.pageobjects
{
    class ShippingPageObject : BasePageObject
    {
        public ShippingPageObject(IWebDriver navegador) : base(navegador)
        {

        }

        public IWebElement GetCheckBox(IWebDriver navegador)
        {

            return navegador.FindElement(By.Id("uniform-cgv"));

        }

        public IWebElement GetProceedToCheckout(IWebDriver navegador)
        {

            return navegador.FindElement(By.Name("processCarrier"));
        }
    }
}
