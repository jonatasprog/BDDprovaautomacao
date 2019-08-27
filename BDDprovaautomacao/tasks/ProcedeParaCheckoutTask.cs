using BDDprovaautomacao.pageobjects;
using OpenQA.Selenium;

namespace BDDprovaautomacao.tasks
{
    class ProcedeParaCheckoutTask
    {
        private IWebDriver navegador;
        public ProcedeParaCheckoutObject buttonAddToCart;

        public ProcedeParaCheckoutTask(IWebDriver navegador)
        {
            this.navegador = navegador;
            this.buttonAddToCart = new ProcedeParaCheckoutObject(this.navegador);
        }

        public void ClicarBotao()
        {
            this.buttonAddToCart.GetProceedToCheckout().Click();
        }
    }
}