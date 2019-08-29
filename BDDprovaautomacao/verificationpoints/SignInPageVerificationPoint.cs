using BDDprovaautomacao.utils;
using NUnit.Framework;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;

namespace BDDprovaautomacao.verificationPoints
{
        class SignInPageVerificationPoint : BasePageObject
        {
            public SignInPageVerificationPoint(IWebDriver navegador) : base(navegador) { }

            public void GetHomePagelVP()
            {
                try
                {
                    string element = navegador.FindElement(By.Id("customer_firstname")).Text;
                    Assert.AreEqual(element, "customer_firstname");
                    Report.Log(LogStatus.Pass, "SignInPage successfully acessed!", ScreenshotUtils.Capture());
                }
                catch
                {
                    Report.Log(LogStatus.Error, "Page Not Found!", ScreenshotUtils.Capture());
                    throw new NoSuchElementException("Page Not Found!");
                }
            }
        }
}