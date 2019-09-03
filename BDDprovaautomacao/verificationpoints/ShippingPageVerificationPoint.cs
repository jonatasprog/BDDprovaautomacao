using BDDprovaautomacao.utils;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;

namespace BDDprovaautomacao.verificationPoints
{
    class ShippingPageVerificationPoint : BaseDriver
    {
        public ShippingPageVerificationPoint(IWebDriver navegador) : base(navegador) { }

        public void GetShippingPageVP()
        {
            try
            {
                System.Threading.Thread.Sleep(4000);
                IWebElement element = navegador.FindElement(By.Id("HOOK_BEFORECARRIER"));
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