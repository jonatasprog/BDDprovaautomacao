using BDDprovaautomacao.pageobjects;
using OpenQA.Selenium;

namespace BDDprovaautomacao.tasks
{
    class AddToCartTask
    {
        private IWebDriver navegador;
        public AddToCartObject buttonAddToCart;

        public AddToCartTask(IWebDriver navegador)
        {
            this.navegador = navegador;
            this.buttonAddToCart = new AddToCartObject(this.navegador);
        }
        
        public void ClicarBotao()
        {
            this.buttonAddToCart.GetAddToCartButton().Click();
        }
    }
}