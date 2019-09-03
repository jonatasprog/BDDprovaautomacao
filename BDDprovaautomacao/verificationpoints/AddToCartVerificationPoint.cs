using BDDprovaautomacao.utils;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;

namespace BDDprovaautomacao.verificationPoints
{
    class AddToCartVerificationPoint : BaseDriver
    {
        public AddToCartVerificationPoint(IWebDriver navegador) : base(navegador)
        {

        }
        public void AddToCartPageVP()
        {
            try
            {
                IWebElement element = navegador.FindElement(By.Id("center_column"));                
                System.Threading.Thread.Sleep(10000);
                IJavaScriptExecutor jse = (IJavaScriptExecutor)navegador;
                jse.ExecuteScript("window.scrollBy(0,650)");
                Report.Log(LogStatus.Pass, "CartPage successfully accessed!", ScreenshotUtils.Capture());
            }
            catch
            {
                Report.Log(LogStatus.Error, "Page Not Found!", ScreenshotUtils.Capture());
                throw new NoSuchElementException("Page Not Found!");
            }
        }
    }
}