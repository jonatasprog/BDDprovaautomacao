using BDDprovaautomacao.utils;
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace BDDprovaautomacao.verificationpoints
{
    class PaginaConfirmacaoVerificationPoint : BasePageObject
    {

        public PaginaConfirmacaoVerificationPoint(IWebDriver navegador) : base(navegador)
        {

        }
        public String GetTitulo()
        {

            String titulo;
            titulo = navegador.FindElement(By.LinkText("Proceed to checkout")).Text;
            Assert.AreEqual(titulo, "Proceed to checkout");

            return titulo;
        }

        public String GetTitulo2()
        {
            String titulo;
            titulo = navegador.FindElement(By.XPath("//span [text()='Faded Short Sleeve T-shirts']")).Text;
            Assert.AreEqual(titulo, "Faded Short Sleeve T-shirts");

            return titulo;

        }
    }
}