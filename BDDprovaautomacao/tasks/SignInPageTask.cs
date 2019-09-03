using BDDprovaautomacao.datapools;
using BDDprovaautomacao.pageobjects;
using BDDprovaautomacao.utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Text;

namespace BDDprovaautomacao.tasks
{
    class SignInPageTask
    {
        private IWebDriver navegador;
        public SignInPageObject campoCadastrarEmail, buttonCreateAccount, radioButton, campoCustomerFirstName, campoCustomerLastName, campoPassword,
                comboDay, comboMonth, comboYear, campoFirstName, campoLastName, campoCompany, campoAdress, campoAdress2, campoCity, comboState, campoPostalCode, comboCountry,
                campoAdditionalInformation, campoHomePhone, campoMobilePhone, campoAdressAlias, registerButton;

        public object TimeUnit { get; private set; }

        public SignInPageTask(IWebDriver navegador)
        {
            this.navegador = navegador;
            campoCadastrarEmail = new SignInPageObject(navegador);
            buttonCreateAccount = new SignInPageObject(navegador);
            radioButton = new SignInPageObject(navegador);
            campoCustomerFirstName = new SignInPageObject(navegador);
            campoCustomerLastName = new SignInPageObject(navegador);
            campoPassword = new SignInPageObject(navegador);
            comboDay = new SignInPageObject(navegador);
            comboMonth = new SignInPageObject(navegador);
            comboYear = new SignInPageObject(navegador);
            campoFirstName = new SignInPageObject(navegador);
            campoLastName = new SignInPageObject(navegador);
            campoCompany = new SignInPageObject(navegador);
            campoAdress = new SignInPageObject(navegador);
            campoAdress2 = new SignInPageObject(navegador);
            campoCity = new SignInPageObject(navegador);
            comboState = new SignInPageObject(navegador);
            campoPostalCode = new SignInPageObject(navegador);
            comboCountry = new SignInPageObject(navegador);
            campoAdditionalInformation = new SignInPageObject(navegador);
            campoHomePhone = new SignInPageObject(navegador);
            campoMobilePhone = new SignInPageObject(navegador);
            campoAdressAlias = new SignInPageObject(navegador);
            registerButton = new SignInPageObject(navegador);

        }
        //Method to generate random email
        public void CadastrarEmail()
        {

            String SALTCHARS = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder salt = new StringBuilder();
            Random rnd = new Random();

            while (salt.Length < 10)
            { // length of the random string.
                int index = (int)(rnd.NextDouble() * SALTCHARS.Length);
                salt.Append(SALTCHARS[index]);                
            }
            String saltStr = salt.ToString();

            campoCadastrarEmail.SetEmailAdress(navegador).SendKeys(saltStr + "@gmail.com");

        }

        public void ClicarBotao()
        {
            buttonCreateAccount.GetSubmitCreateButton(navegador).Click();
        }
        //This method is using our datapool csv file to input userdata
        public void PreencherFormulario()
        {
            CsvDatapool datapool = new CsvDatapool(ProjConfig.GetPath("\\BDDprovaautomacao\\datapools\\csvs\\FormularioCadastro.csv"));            
            
            radioButton.GetRadioButton(navegador).Click();            
            campoCustomerFirstName.SetFirstCustomerName(navegador).SendKeys(datapool.GetValue("FirstName"));
            campoCustomerLastName.SetLastCustomerName(navegador).SendKeys(datapool.GetValue("LastName"));
            campoPassword.SetPasswd(navegador).SendKeys(datapool.GetValue("Password"));
            comboDay.ComboDay(navegador).Click();
            new SelectElement(comboDay.ComboDay(navegador)).SelectByValue(datapool.GetValue("BirthDay"));            
            comboMonth.ComboMonth(navegador).Click();
            new SelectElement(comboMonth.ComboMonth(navegador)).SelectByText(datapool.GetValue("BirthMonth"));            
            comboYear.ComboYear(navegador).Click();
            new SelectElement(comboYear.ComboYear(navegador)).SelectByText(datapool.GetValue("BirthYear"));
            campoCompany.SetCompany(navegador).SendKeys(datapool.GetValue("Company"));
            campoAdress.SetAdress(navegador).SendKeys(datapool.GetValue("AddressField1"));
            campoAdress2.SetAdress2(navegador).SendKeys(datapool.GetValue("AddressField2"));
            campoCity.SetCity(navegador).SendKeys(datapool.GetValue("City"));
            comboState.ComboState(navegador).Click();            
            new SelectElement(comboState.ComboState(navegador)).SelectByText(datapool.GetValue("State"));
            campoPostalCode.SetPostalCode(navegador).SendKeys(datapool.GetValue("PostalCode"));
            comboCountry.SetComboCountry(navegador).Click();            
            new SelectElement(comboCountry.SetComboCountry(navegador)).SelectByText(datapool.GetValue("Country"));
            campoAdditionalInformation.SetAdditionalInformation(navegador).SendKeys(datapool.GetValue("AdditionalInformation"));
            campoHomePhone.SetHomePhone(navegador).SendKeys(datapool.GetValue("HomePhone"));
            campoMobilePhone.SetMobilePhone(navegador).SendKeys(datapool.GetValue("MobilePhone"));
            campoAdressAlias.SetAdressAlias(navegador).SendKeys(datapool.GetValue("EmailAdressAlias"));
            registerButton.GetRegisterButton(navegador).Click();

        }
    }
}