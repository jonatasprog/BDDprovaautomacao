using BDDprovaautomacao.utils;
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace BDDprovaautomacao.verificationpoints
{
    class ProductConfirmationVerificationPoint : BaseDriver
    {
        public ProductConfirmationVerificationPoint(IWebDriver navegador) : base(navegador)
        {

        }
        public String GetTitulo()
        {
            String titulo;
            titulo = navegador.FindElement(By.XPath("//span [text()='Faded Short Sleeve T-shirts']")).Text;
            Assert.AreEqual(titulo, "Faded Short Sleeve T-shirts");

            return titulo;

        }
    }
}