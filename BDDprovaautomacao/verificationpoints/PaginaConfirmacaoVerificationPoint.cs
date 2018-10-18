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
        public String getTitulo()
        {

            String titulo;
            titulo = navegador.FindElement(By.LinkText("Proceed to checkout")).Text;
            Assert.AreEqual(titulo, "Proceed to checkout");

            return titulo;
        }
    }
}
