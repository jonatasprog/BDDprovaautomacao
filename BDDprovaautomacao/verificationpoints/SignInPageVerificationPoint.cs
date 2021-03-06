﻿using BDDprovaautomacao.utils;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;

namespace BDDprovaautomacao.verificationPoints
{
    class SignInPageVerificationPoint : BaseDriver
    {
        public SignInPageVerificationPoint(IWebDriver navegador) : base(navegador) { }

        public void GetSignInPageVP()
        {
            try
            {
                IWebElement element = navegador.FindElement(By.Id("authentication"));                
                System.Threading.Thread.Sleep(10000);
                IJavaScriptExecutor jse = (IJavaScriptExecutor)navegador;
                jse.ExecuteScript("window.scrollBy(0,650)");
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