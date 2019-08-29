using BDDprovaautomacao.utils;
using OpenQA.Selenium;

namespace BDDprovaautomacao.pageobjects
{
    class AddressPageObject : BasePageObject
    {
        public AddressPageObject(IWebDriver navegador) : base(navegador)
        {

        }

        public IWebElement GetProceedToCheckout()
        {

            return navegador.FindElement(By.Name("processAddress"));

        }
    }
}