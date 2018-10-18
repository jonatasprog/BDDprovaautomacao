using BDDprovaautomacao.utils;
using OpenQA.Selenium;

namespace BDDprovaautomacao.pageobjects
{
    class ShippingPageObject : BasePageObject
    {
        public ShippingPageObject(IWebDriver navegador) : base(navegador)
        {

        }

        public IWebElement getCheckBox(IWebDriver navegador)
        {

            return navegador.FindElement(By.Id("uniform-cgv"));

        }

        public IWebElement getProceedToCheckout(IWebDriver navegador)
        {

            return navegador.FindElement(By.Name("processCarrier"));
        }
    }
}
