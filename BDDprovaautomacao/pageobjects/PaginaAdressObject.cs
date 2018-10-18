using BDDprovaautomacao.utils;
using OpenQA.Selenium;

namespace BDDprovaautomacao.pageobjects
{
    class PaginaAdressObject : BasePageObject
    {
        public PaginaAdressObject(IWebDriver navegador) : base(navegador)
        {

        }

        public IWebElement getProceedToCheckout()
        {

            return this.navegador.FindElement(By.Name("processAddress"));

        }
    }
}
