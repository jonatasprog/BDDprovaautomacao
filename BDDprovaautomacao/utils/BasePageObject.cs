using OpenQA.Selenium;

namespace BDDprovaautomacao.utils
{
    public class BasePageObject
    {
        public IWebDriver navegador;

        public BasePageObject(IWebDriver navegador)
        {
            this.navegador = navegador;
        }
    }
}