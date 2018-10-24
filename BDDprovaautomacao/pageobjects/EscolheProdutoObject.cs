﻿using BDDprovaautomacao.utils;
using OpenQA.Selenium;
using System;

namespace BDDprovaautomacao.pageobjects
{
    public class EscolheProdutoObject : BasePageObject
    {
        
        public EscolheProdutoObject(IWebDriver navegador): base (
            navegador)
        {
            
        }        

        public IWebElement getImagemDoProduto()
        {
            navegador.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10.00);
            return this.navegador.FindElement(By.PartialLinkText("Faded Short Sleeve T-shirts"));
        }
    }
}