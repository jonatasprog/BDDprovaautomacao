using BDDprovaautomacao.utils;
using NUnit.Framework;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;

namespace BDDprovaautomacao.verificationpoints
{
    class PaymentVerificationPoint : BaseDriver
    {
        public PaymentVerificationPoint(IWebDriver navegador) : base(navegador) { }

        public String GetTotal()
        {

            String total;
            total = navegador.FindElement(By.Id("total_price")).Text;
            Assert.AreEqual(total, "$19.25");

            return total;
        }

        public String GetTotalAmount()
        {

            String total;
            total = navegador.FindElement(By.Id("amount")).Text;
            Assert.AreEqual(total, "$19.25");

            return total;
        }

        public void GetPaymentPageVP()
        {
            try
            {
                System.Threading.Thread.Sleep(4000);
                IWebElement element = navegador.FindElement(By.Id("total_price"));
                Report.Log(LogStatus.Pass, "PaymentPage successfully acessed!", ScreenshotUtils.Capture());
            }
            catch
            {
                Report.Log(LogStatus.Error, "Page Not Found!", ScreenshotUtils.Capture());
                throw new NoSuchElementException("Page Not Found!");
            }
        }
    }
}