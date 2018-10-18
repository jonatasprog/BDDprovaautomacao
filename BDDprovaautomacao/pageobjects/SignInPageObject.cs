using BDDprovaautomacao.utils;
using OpenQA.Selenium;

namespace BDDprovaautomacao.pageobjects
{
    class SignInPageObject : BasePageObject
    {
        public SignInPageObject(IWebDriver navegador) : base(navegador)
        {

        }

        public IWebElement setEmailAdress(IWebDriver navegador)
        {
            navegador.FindElement(By.Id("email_create")).Clear();
            return navegador.FindElement(By.Id("email_create"));
        }

        public IWebElement getSubmitCreateButton(IWebDriver navegador)
        {

            return navegador.FindElement(By.Id("SubmitCreate"));
        }

        public IWebElement getRadioButton(IWebDriver navegador)
        {

            return navegador.FindElement(By.Id("uniform-id_gender1"));
        }

        public IWebElement setFirstCustomerName(IWebDriver navegador)
        {

            return navegador.FindElement(By.Id("customer_firstname"));
        }

        public IWebElement setLastCustomerName(IWebDriver navegador)
        {

            return navegador.FindElement(By.Id("customer_lastname"));
        }

        public IWebElement setEmail(IWebDriver navegador)
        {
            navegador.FindElement(By.Id("email")).Clear();
            return navegador.FindElement(By.Id("email"));
        }

        public IWebElement setPasswd(IWebDriver navegador)
        {

            return navegador.FindElement(By.Id("passwd"));
        }

        public IWebElement comboDay(IWebDriver navegador)
        {

            return navegador.FindElement(By.Id("days"));
        }

        public IWebElement comboMonth(IWebDriver navegador)
        {

            return navegador.FindElement(By.Id("months"));
        }

        public IWebElement comboYear(IWebDriver navegador)
        {

            return navegador.FindElement(By.Id("years"));
        }

        public IWebElement setFirstName(IWebDriver navegador)
        {

            return navegador.FindElement(By.Id("firstname"));
        }

        public IWebElement setLastName(IWebDriver navegador)
        {

            return navegador.FindElement(By.Id("lastname"));
        }

        public IWebElement setCompany(IWebDriver navegador)
        {

            return navegador.FindElement(By.Id("company"));
        }

        public IWebElement setAdress(IWebDriver navegador)
        {

            return navegador.FindElement(By.Id("address1"));
        }

        public IWebElement setAdress2(IWebDriver navegador)
        {

            return navegador.FindElement(By.Id("address2"));
        }

        public IWebElement setCity(IWebDriver navegador)
        {

            return navegador.FindElement(By.Id("city"));
        }

        public IWebElement comboState(IWebDriver navegador)
        {

            return navegador.FindElement(By.Name("id_state"));
        }

        public IWebElement setPostalCode(IWebDriver navegador)
        {

            return navegador.FindElement(By.Id("postcode"));
        }

        public IWebElement setComboCountry(IWebDriver navegador)
        {

            return navegador.FindElement(By.Id("id_country"));
        }

        public IWebElement setAdditionalInformation(IWebDriver navegador)
        {

            return navegador.FindElement(By.Id("other"));
        }

        public IWebElement setHomePhone(IWebDriver navegador)
        {

            return navegador.FindElement(By.Id("phone"));
        }

        public IWebElement setMobilePhone(IWebDriver navegador)
        {

            return navegador.FindElement(By.Id("phone_mobile"));
        }

        public IWebElement setAdressAlias(IWebDriver navegador)
        {
            navegador.FindElement(By.Id("alias")).Clear();
            return navegador.FindElement(By.Id("alias"));
        }

        public IWebElement getRegisterButton(IWebDriver navegador)
        {

            return navegador.FindElement(By.Id("submitAccount"));
        }
    }
}