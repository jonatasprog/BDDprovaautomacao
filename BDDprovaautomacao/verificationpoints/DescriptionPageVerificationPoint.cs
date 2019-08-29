using BDDprovaautomacao.utils;
using NUnit.Framework;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;

namespace BDDprovaautomacao.verificationpoints
{
    class DescriptionPageVerificationPoint : BasePageObject
    {
        public DescriptionPageVerificationPoint(IWebDriver navegador) : base(navegador) { }


        public String GetTituloVP()
        {
            try
            {
                String titulo;
                titulo = navegador.FindElement(By.XPath("//h3[contains(text(),'More info')]")).Text;
                Assert.AreEqual(titulo, "MORE INFO");
                Report.Log(LogStatus.Pass, "DescriptionPage successfully acessed!", ScreenshotUtils.Capture());

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