using BDDprovaautomacao.utils;
using OpenQA.Selenium;

namespace BDDprovaautomacao.pageobjects
{
    class SignInPageObject : BasePageObject
    {
        public SignInPageObject(IWebDriver navegador) : base(navegador)
        {

        }

        public IWebElement SetEmailAdress(IWebDriver navegador)
        {
            navegador.FindElement(By.Id("email_create")).Clear();
            return navegador.FindElement(By.Id("email_create"));
        }

        public IWebElement GetSubmitCreateButton(IWebDriver navegador)
        {

            return navegador.FindElement(By.Id("SubmitCreate"));
        }

        public IWebElement GetRadioButton(IWebDriver navegador)
        {

            return navegador.FindElement(By.Id("uniform-id_gender1"));
        }

        public IWebElement SetFirstCustomerName(IWebDriver navegador)
        {

            return navegador.FindElement(By.Id("customer_firstname"));
        }

        public IWebElement SetLastCustomerName(IWebDriver navegador)
        {

            return navegador.FindElement(By.Id("customer_lastname"));
        }

        public IWebElement SetEmail(IWebDriver navegador)
        {
            navegador.FindElement(By.Id("email")).Clear();
            return navegador.FindElement(By.Id("email"));
        }

        public IWebElement SetPasswd(IWebDriver navegador)
        {

            return navegador.FindElement(By.Id("passwd"));
        }

        public IWebElement ComboDay(IWebDriver navegador)
        {

            return navegador.FindElement(By.Id("days"));
        }

        public IWebElement ComboMonth(IWebDriver navegador)
        {

            return navegador.FindElement(By.Id("months"));
        }

        public IWebElement ComboYear(IWebDriver navegador)
        {

            return navegador.FindElement(By.Id("years"));
        }

        public IWebElement SetFirstName(IWebDriver navegador)
        {

            return navegador.FindElement(By.Id("firstname"));
        }

        public IWebElement SetLastName(IWebDriver navegador)
        {

            return navegador.FindElement(By.Id("lastname"));
        }

        public IWebElement SetCompany(IWebDriver navegador)
        {

            return navegador.FindElement(By.Id("company"));
        }

        public IWebElement SetAdress(IWebDriver navegador)
        {

            return navegador.FindElement(By.Id("address1"));
        }

        public IWebElement SetAdress2(IWebDriver navegador)
        {

            return navegador.FindElement(By.Id("address2"));
        }

        public IWebElement SetCity(IWebDriver navegador)
        {

            return navegador.FindElement(By.Id("city"));
        }

        public IWebElement ComboState(IWebDriver navegador)
        {

            return navegador.FindElement(By.Name("id_state"));
        }

        public IWebElement SetPostalCode(IWebDriver navegador)
        {

            return navegador.FindElement(By.Id("postcode"));
        }

        public IWebElement SetComboCountry(IWebDriver navegador)
        {

            return navegador.FindElement(By.Id("id_country"));
        }

        public IWebElement SetAdditionalInformation(IWebDriver navegador)
        {

            return navegador.FindElement(By.Id("other"));
        }

        public IWebElement SetHomePhone(IWebDriver navegador)
        {

            return navegador.FindElement(By.Id("phone"));
        }

        public IWebElement SetMobilePhone(IWebDriver navegador)
        {

            return navegador.FindElement(By.Id("phone_mobile"));
        }

        public IWebElement SetAdressAlias(IWebDriver navegador)
        {
            navegador.FindElement(By.Id("alias")).Clear();
            return navegador.FindElement(By.Id("alias"));
        }

        public IWebElement GetRegisterButton(IWebDriver navegador)
        {

            return navegador.FindElement(By.Id("submitAccount"));
        }
    }
}