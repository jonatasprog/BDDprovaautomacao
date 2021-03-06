﻿using BDDprovaautomacao.utils;
using OpenQA.Selenium;
using System;

namespace BDDprovaautomacao.pageobjects
{
    public class HomePageObject : BaseDriver
    {
        
        public HomePageObject(IWebDriver navegador): base (
            navegador)
        {
            
        }        

        public IWebElement GetImagemDoProduto()
        {
            navegador.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10.00);
            return navegador.FindElement(By.PartialLinkText("Faded Short Sleeve T-shirts"));
        }
    }
}