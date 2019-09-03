using BDDprovaautomacao.utils;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;

namespace BDDprovaautomacao.verificationpoints
{
    class AddressPageVerificationPoint : BaseDriver
    {
        public AddressPageVerificationPoint(IWebDriver navegador) : base(navegador)
        {

        }
        public void GetAddressPageVP()
        {
            try
            {
                System.Threading.Thread.Sleep(4000);
                IWebElement element = navegador.FindElement(By.Id("customer_firstname"));                
                Report.Log(LogStatus.Pass, "AddressPage successfully acessed!", ScreenshotUtils.Capture());
            }
            catch
            {
                Report.Log(LogStatus.Error, "Page Not Found!", ScreenshotUtils.Capture());
                throw new NoSuchElementException("Page Not Found!");
            }
        }
    }
}