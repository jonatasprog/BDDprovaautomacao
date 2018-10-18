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

        public void clicarBotao()
        {
            this.buttonProceedToCheckout.getProceedToCheckout(navegador).Click();
        }
    }
}

