using BDDprovaautomacao.utils;
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace BDDprovaautomacao.verificationpoints
{
    class ConfirmacaoDoProdutoVerificationPoint : BasePageObject
    {
        public ConfirmacaoDoProdutoVerificationPoint(IWebDriver navegador) : base(navegador)
        {

        }

        public String getTitulo()
        {

            String titulo;
            titulo = navegador.FindElement(By.LinkText("Faded Short Sleeve T-shirts")).Text;
            Assert.AreEqual(titulo, "Faded Short Sleeve T-shirts");

            return titulo;
        }
    }
}
