using BDDprovaautomacao.utils;
using OpenQA.Selenium;

namespace BDDprovaautomacao.pageobjects
{
    class ProcedeParaCheckoutObject : BasePageObject
    {
        public ProcedeParaCheckoutObject(IWebDriver navegador) : base(navegador)
        {

        }

        public IWebElement GetProceedToCheckout()
        {

            return navegador.FindElement(By.LinkText("Proceed to checkout"));
        }
    }
}
