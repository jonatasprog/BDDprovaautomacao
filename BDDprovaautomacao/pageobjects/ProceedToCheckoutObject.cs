using BDDprovaautomacao.utils;
using OpenQA.Selenium;

namespace BDDprovaautomacao.pageobjects
{
    class ProceedToCheckoutObject : BasePageObject
    {
        public ProceedToCheckoutObject(IWebDriver navegador) : base(navegador)
        {

        }

        public IWebElement GetProceedToCheckout()
        {

            return navegador.FindElement(By.LinkText("Proceed to checkout"));
        }
    }
}
