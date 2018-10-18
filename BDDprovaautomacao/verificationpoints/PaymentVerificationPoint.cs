using BDDprovaautomacao.utils;
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace BDDprovaautomacao.verificationpoints
{
    class PaymentVerificationPoint : BasePageObject
    {
        public PaymentVerificationPoint(IWebDriver navegador) : base(navegador) { }

        public String getTotal()
        {

            String total;
            total = navegador.FindElement(By.Id("total_price")).Text;
            Assert.AreEqual(total, "$19.25");

            return total;
        }

        public String getTotalAmount()
        {

            String total;
            total = navegador.FindElement(By.Id("amount")).Text;
            Assert.AreEqual(total, "$19.25");

            return total;
        }
    }
}
