using BDDprovaautomacao.pageobjects;
using OpenQA.Selenium;

namespace BDDprovaautomacao.tasks
{
    class EscolheProdutoTask
    {
        private IWebDriver navegador;
        public EscolheProdutoObject produtoPageObject;

        public EscolheProdutoTask(IWebDriver navegador)
        {
            this.navegador = navegador;
            this.produtoPageObject = new EscolheProdutoObject(this.navegador);
        }

        public void clicarImagem()
        {
            this.produtoPageObject.getImagemDoProduto().Click();            
        }
    }
}
