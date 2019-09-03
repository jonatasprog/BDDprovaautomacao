using BDDprovaautomacao.utils;
using NUnit.Framework;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;

namespace BDDprovaautomacao.verificationpoints
{
    class ConfirmationPageVerificationPoint : BaseDriver
    {

        public ConfirmationPageVerificationPoint(IWebDriver navegador) : base(navegador)
        {

        }         
        public String GetTituloVP2()
        {
            try
            {
                String titulo;
                titulo = navegador.FindElement(By.XPath("//span [text()='Faded Short Sleeve T-shirts']")).Text;
                Assert.AreEqual(titulo, "Faded Short Sleeve T-shirts");
                Report.Log(LogStatus.Pass, "Product Added!", ScreenshotUtils.Capture());

                return titulo;
            }
            catch
            {
                Report.Log(LogStatus.Error, "Product Not Added!", ScreenshotUtils.Capture());
                throw new NoSuchElementException("Product Not Added!");
            }
        }

        public String GetTituloVP()
        {
            try
            {
                String titulo;
                titulo = navegador.FindElement(By.LinkText("Proceed to checkout")).Text;
                Assert.AreEqual(titulo, "Proceed to checkout");
                Report.Log(LogStatus.Pass, "ConfirmationPage successfully acessed!", ScreenshotUtils.Capture());

                return titulo;
            }
            catch
            {
                Report.Log(LogStatus.Error, "Page Not Found!", ScreenshotUtils.Capture());
                throw new NoSuchElementException("Page Not Found!");
            }
        }
    }
}