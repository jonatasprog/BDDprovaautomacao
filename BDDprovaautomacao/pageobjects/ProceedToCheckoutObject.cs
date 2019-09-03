using BDDprovaautomacao.utils;
using OpenQA.Selenium;

namespace BDDprovaautomacao.pageobjects
{
    class ProceedToCheckoutObject : BaseDriver
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
