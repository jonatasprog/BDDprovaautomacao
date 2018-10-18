using BDDprovaautomacao.pageobjects;
using OpenQA.Selenium;

namespace BDDprovaautomacao.tasks
{
    class PaymentTask
    {
        private IWebDriver navegador;
        public PaymentPageObject buttonPayByBankWire;

        public PaymentTask(IWebDriver navegador)
        {
            this.navegador = navegador;
            this.buttonPayByBankWire = new PaymentPageObject(this.navegador);
        }

        public void clicarBotao()
        {
            this.buttonPayByBankWire.getPayByBankWire(navegador).Click();
        }

        public void clicarBotaoConfirmandoPagamento()
        {
            this.buttonPayByBankWire.getIConfirmMyOrder(navegador).Click();
        }
    }
}
