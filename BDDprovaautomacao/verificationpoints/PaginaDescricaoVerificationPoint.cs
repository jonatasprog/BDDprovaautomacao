using BDDprovaautomacao.utils;
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace BDDprovaautomacao.verificationpoints
{
    class PaginaDescricaoVerificationPoint : BasePageObject
    {
        public PaginaDescricaoVerificationPoint(IWebDriver navegador) : base(navegador) { }
        

        public String GetTitulo()
        {   
            String titulo;
            titulo = navegador.FindElement(By.XPath("//h3[contains(text(),'More info')]")).Text;
            Assert.AreEqual(titulo, "MORE INFO");

            return titulo;

        }
    }
}