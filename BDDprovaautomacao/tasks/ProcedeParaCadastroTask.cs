using BDDprovaautomacao.pageobjects;
using OpenQA.Selenium;

namespace BDDprovaautomacao.tasks
{
    class ProcedeParaCadastroTask
    {
        private IWebDriver navegador;
        public ProcedeParaCadastroObject buttonProceedToCheckout;

        public ProcedeParaCadastroTask(IWebDriver navegador)
        {
            this.navegador = navegador;
            this.buttonProceedToCheckout = new ProcedeParaCadastroObject(this.navegador);
        }

        public void ClicarBotao()
        {
            this.buttonProceedToCheckout.GetProceedToCheckout(navegador).Click();
        }
    }
}