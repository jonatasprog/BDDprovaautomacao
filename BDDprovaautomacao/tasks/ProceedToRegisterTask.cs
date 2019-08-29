using BDDprovaautomacao.pageobjects;
using OpenQA.Selenium;

namespace BDDprovaautomacao.tasks
{
    class ProceedToRegisterTask
    {
        private IWebDriver navegador;
        public ProceedToRegisterObject buttonProceedToCheckout;

        public ProceedToRegisterTask(IWebDriver navegador)
        {
            this.navegador = navegador;
            this.buttonProceedToCheckout = new ProceedToRegisterObject(this.navegador);
        }

        public void ClicarBotao()
        {
            this.buttonProceedToCheckout.GetProceedToCheckout(navegador).Click();
        }
    }
}