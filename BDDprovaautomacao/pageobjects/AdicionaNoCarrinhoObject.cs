using BDDprovaautomacao.utils;
using OpenQA.Selenium;


namespace BDDprovaautomacao.pageobjects
{
    class AdicionaNoCarrinhoObject : BasePageObject
    {
        public AdicionaNoCarrinhoObject(IWebDriver navegador) : base(navegador)
        {

        }

        public IWebElement GetAddToCartButton()
        {            
            return this.navegador.FindElement(By.Name("Submit"));
        }
    }
}