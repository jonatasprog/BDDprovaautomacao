using BDDprovaautomacao.utils;
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace BDDprovaautomacao.verificationpoints
{
    class PaymentVerificationPoint : BasePageObject
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
    }
}