using BDDprovaautomacao.pageobjects;
using OpenQA.Selenium;

namespace BDDprovaautomacao.tasks
{
    class AdicionaNoCarrinhoTask
    {
        private IWebDriver navegador;
        public AdicionaNoCarrinhoObject buttonAddToCart;

        public AdicionaNoCarrinhoTask(IWebDriver navegador)
        {
            this.navegador = navegador;
            this.buttonAddToCart = new AdicionaNoCarrinhoObject(this.navegador);
        }
        
        public void ClicarBotao()
        {
            this.buttonAddToCart.GetAddToCartButton().Click();
        }
    }
}