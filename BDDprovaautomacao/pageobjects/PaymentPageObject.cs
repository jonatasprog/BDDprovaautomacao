﻿using BDDprovaautomacao.utils;
using OpenQA.Selenium;

namespace BDDprovaautomacao.pageobjects
{
    class PaymentPageObject : BaseDriver
    {
        public PaymentPageObject(IWebDriver navegador) : base(navegador)
        {

        }

        public IWebElement GetPayByBankWire(IWebDriver navegador)
        {

            return navegador.FindElement(By.ClassName("bankwire"));

        }

        public IWebElement GetIConfirmMyOrder(IWebDriver navegador)
        {

            return navegador.FindElement(By.CssSelector(".cart_navigation .button-medium"));

        }
    }
}