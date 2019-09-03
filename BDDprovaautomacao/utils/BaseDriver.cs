using OpenQA.Selenium;

namespace BDDprovaautomacao.utils
{
    public class BaseDriver
    {
        //Variable doesn't need to be created in other classes because of inheritance mechanism
        public IWebDriver navegador;

        public BaseDriver(IWebDriver navegador)
        {
            this.navegador = navegador;
        }
    }
}