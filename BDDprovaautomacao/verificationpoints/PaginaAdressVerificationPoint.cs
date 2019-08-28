using BDDprovaautomacao.utils;
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace BDDprovaautomacao.verificationpoints
{
    class PaginaAdressVerificationPoint : BasePageObject
    {
        public PaginaAdressVerificationPoint(IWebDriver navegador) : base(navegador)
        {

        }
        public String GetAdress()
        {

            String titulo;
            titulo = navegador.FindElement(By.XPath("//ul[@id='address_delivery']//li[@class='address_address1 address_address2'][contains(text(),'Avenida Ipiranga, número 17 Próximo a PUCRS')]")).Text;
            Assert.AreEqual(titulo, "Avenida Ipiranga, número 17 Próximo a PUCRS");

            return titulo;
        }
    }
}