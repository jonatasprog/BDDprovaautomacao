using BDDprovaautomacao.utils;
using OpenQA.Selenium;

namespace BDDprovaautomacao.pageobjects
{
    class AddToCartObject : BaseDriver
    {
        public AddToCartObject(IWebDriver navegador) : base(navegador)
        {

        }

        public IWebElement GetAddToCartButton()
        {            
            return navegador.FindElement(By.Name("Submit"));
        }
    }
}