using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace BDDprovaautomacao.utils
{
    public class TestBase
    {
        public static IWebDriver createChrome()
        {            
            new DriverManager().SetUpDriver(new ChromeConfig());
            IWebDriver navegador = new ChromeDriver();            
            navegador.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10.00);
            navegador.Manage().Window.Maximize();
            navegador.Navigate().GoToUrl("http://www.automationpractice.com");

            return navegador;
        }
    }
}
