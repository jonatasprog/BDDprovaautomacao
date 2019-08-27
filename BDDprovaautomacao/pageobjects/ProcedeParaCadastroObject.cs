﻿using BDDprovaautomacao.utils;
using OpenQA.Selenium;

namespace BDDprovaautomacao.pageobjects
{
    class ProcedeParaCadastroObject : BasePageObject
    {
        public ProcedeParaCadastroObject(IWebDriver navegador) : base(navegador)
        {

        }

        public IWebElement GetProceedToCheckout(IWebDriver navegador)
        {

            return navegador.FindElement(By.LinkText("Proceed to checkout"));
        }
    }
}
