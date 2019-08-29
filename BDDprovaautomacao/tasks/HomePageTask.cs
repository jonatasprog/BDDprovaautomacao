using BDDprovaautomacao.pageobjects;
using OpenQA.Selenium;

namespace BDDprovaautomacao.tasks
{
    class HomePageTask
    {
        private IWebDriver navegador;
        public HomePageObject produtoPageObject;

        public HomePageTask(IWebDriver navegador)
        {
            this.navegador = navegador;
            this.produtoPageObject = new HomePageObject(this.navegador);
        }

        public void ClicarImagem()
        {
            this.produtoPageObject.GetImagemDoProduto().Click();            
        }
    }
}