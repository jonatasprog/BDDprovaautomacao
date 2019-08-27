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

        public void ClicarBotao()
        {
            this.buttonPayByBankWire.GetPayByBankWire(navegador).Click();
        }

        public void ClicarBotaoConfirmandoPagamento()
        {
            this.buttonPayByBankWire.GetIConfirmMyOrder(navegador).Click();
        }
    }
}