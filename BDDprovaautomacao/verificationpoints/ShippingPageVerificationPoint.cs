using BDDprovaautomacao.utils;
using NUnit.Framework;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;

namespace BDDprovaautomacao.verificationPoints
{    
        class ShippingPageVerificationPoint : BasePageObject
        {
            public ShippingPageVerificationPoint(IWebDriver navegador) : base(navegador) { }

            public void GetHomePagelVP()
            {
                try
                {
                    string element = navegador.FindElement(By.Id("uniform-cgv")).Text;
                    Assert.AreEqual(element, "uniform-cgv");
                    Report.Log(LogStatus.Pass, "ShippingPage successfully acessed!", ScreenshotUtils.Capture());
                }
                catch
                {
                    Report.Log(LogStatus.Error, "Page Not Found!", ScreenshotUtils.Capture());
                    throw new NoSuchElementException("Page Not Found!");
                }
            }
        }
}