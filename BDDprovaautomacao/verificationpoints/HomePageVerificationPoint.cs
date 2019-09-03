using BDDprovaautomacao.utils;
using NUnit.Framework;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;

namespace BDDprovaautomacao.verificationPoints
{
    class HomePageVerificationPoint : BaseDriver
    {
        public HomePageVerificationPoint(IWebDriver navegador) : base(navegador) { }

        public void GetHomePageVP()
        {
            try
            {                
                string element = navegador.FindElement(By.PartialLinkText("Faded Short Sleeve T-shirts")).Text;
                Assert.AreEqual(element, "Faded Short Sleeve T-shirts");
                Report.Log(LogStatus.Pass, "Test Automation Practice Homepage successfully executed!", ScreenshotUtils.Capture());
            }
            catch
            {
                Report.Log(LogStatus.Error, "Page Not Found!", ScreenshotUtils.Capture());
                throw new NoSuchElementException("Page Not Found!");
            }
        }
    }
}