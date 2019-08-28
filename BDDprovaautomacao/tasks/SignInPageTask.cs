using BDDprovaautomacao.pageobjects;
using BDDprovaautomacao.utils;
using FrameworkCsharp.Utils;
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
            this.campoCadastrarEmail = new SignInPageObject(navegador);
            this.buttonCreateAccount = new SignInPageObject(navegador);
            this.radioButton = new SignInPageObject(navegador);
            this.campoCustomerFirstName = new SignInPageObject(navegador);
            this.campoCustomerLastName = new SignInPageObject(navegador);
            this.campoPassword = new SignInPageObject(navegador);
            this.comboDay = new SignInPageObject(navegador);
            this.comboMonth = new SignInPageObject(navegador);
            this.comboYear = new SignInPageObject(navegador);
            this.campoFirstName = new SignInPageObject(navegador);
            this.campoLastName = new SignInPageObject(navegador);
            this.campoCompany = new SignInPageObject(navegador);
            this.campoAdress = new SignInPageObject(navegador);
            this.campoAdress2 = new SignInPageObject(navegador);
            this.campoCity = new SignInPageObject(navegador);
            this.comboState = new SignInPageObject(navegador);
            this.campoPostalCode = new SignInPageObject(navegador);
            this.comboCountry = new SignInPageObject(navegador);
            this.campoAdditionalInformation = new SignInPageObject(navegador);
            this.campoHomePhone = new SignInPageObject(navegador);
            this.campoMobilePhone = new SignInPageObject(navegador);
            this.campoAdressAlias = new SignInPageObject(navegador);
            this.registerButton = new SignInPageObject(navegador);

        }

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

            this.campoCadastrarEmail.SetEmailAdress(this.navegador).SendKeys(saltStr + "@gmail.com");

        }

        public void ClicarBotao()
        {
            this.buttonCreateAccount.GetSubmitCreateButton(navegador).Click();
        }

        //public void PreencherFormulario()
        //{
        //    this.radioButton.GetRadioButton(navegador).Click();
        //    this.campoCustomerFirstName.SetFirstCustomerName(navegador).SendKeys("Jônatas");
        //    this.campoCustomerLastName.SetLastCustomerName(navegador).SendKeys("Deorce");
        //    this.campoPassword.SetPasswd(navegador).SendKeys("DbServer123456");
        //    this.comboDay.ComboDay(navegador).Click();
        //    new SelectElement(comboDay.ComboDay(navegador)).SelectByValue("3");
        //    this.comboMonth.ComboMonth(navegador).Click();
        //    new SelectElement(comboMonth.ComboMonth(navegador)).SelectByText("March ");
        //    this.comboYear.ComboYear(navegador).Click();
        //    new SelectElement(comboYear.ComboYear(navegador)).SelectByText("1989  ");
        //    this.campoCompany.SetCompany(navegador).SendKeys("DbServer");
        //    this.campoAdress.SetAdress(navegador).SendKeys("Avenida Ipiranga, número 17");
        //    this.campoAdress2.SetAdress2(navegador).SendKeys("Próximo a PUCRS");
        //    this.campoCity.SetCity(navegador).SendKeys("Porto Alegre");
        //    this.comboState.ComboState(navegador).Click();
        //    new SelectElement(comboState.ComboState(navegador)).SelectByText("Alabama");
        //    this.campoPostalCode.SetPostalCode(navegador).SendKeys("29150");
        //    this.comboCountry.SetComboCountry(navegador).Click();
        //    new SelectElement(comboCountry.SetComboCountry(navegador)).SelectByText("United States");
        //    this.campoAdditionalInformation.SetAdditionalInformation(navegador).SendKeys("Moro no Brasil, porém este form só aceita Estados Unidos no ComboBox!");
        //    this.campoHomePhone.SetHomePhone(navegador).SendKeys("2730907708");
        //    this.campoMobilePhone.SetMobilePhone(navegador).SendKeys("27995322525");
        //    this.campoAdressAlias.SetAdressAlias(navegador).SendKeys("jonatasd@dbserver.com.br");
        //    this.registerButton.GetRegisterButton(navegador).Click();

        //}

        public void PreencherFormulario()
        {
            CsvDatapool datapool = new CsvDatapool(ProjConfig.GetPath("\\BDDprovaautomacao\\datapools\\csvs\\FormularioCadastro.csv"));            
            
            this.radioButton.GetRadioButton(navegador).Click();
            this.campoCustomerFirstName.SetFirstCustomerName(navegador).SendKeys(datapool.GetValue("FirstName"));
            this.campoCustomerLastName.SetLastCustomerName(navegador).SendKeys("Deorce");
            this.campoPassword.SetPasswd(navegador).SendKeys("DbServer123456");
            this.comboDay.ComboDay(navegador).Click();
            new SelectElement(comboDay.ComboDay(navegador)).SelectByValue("3");            
            this.comboMonth.ComboMonth(navegador).Click();
            new SelectElement(comboMonth.ComboMonth(navegador)).SelectByText("March ");            
            this.comboYear.ComboYear(navegador).Click();
            new SelectElement(comboYear.ComboYear(navegador)).SelectByText("1989  ");
            this.campoCompany.SetCompany(navegador).SendKeys("DbServer");
            this.campoAdress.SetAdress(navegador).SendKeys("Avenida Ipiranga, número 17");
            this.campoAdress2.SetAdress2(navegador).SendKeys("Próximo a PUCRS");
            this.campoCity.SetCity(navegador).SendKeys("Porto Alegre");
            this.comboState.ComboState(navegador).Click();            
            new SelectElement(comboState.ComboState(navegador)).SelectByText("Alabama");
            this.campoPostalCode.SetPostalCode(navegador).SendKeys("29150");
            this.comboCountry.SetComboCountry(navegador).Click();            
            new SelectElement(comboCountry.SetComboCountry(navegador)).SelectByText("United States");
            this.campoAdditionalInformation.SetAdditionalInformation(navegador).SendKeys("Moro no Brasil, porém este form só aceita Estados Unidos no ComboBox!");
            this.campoHomePhone.SetHomePhone(navegador).SendKeys("2730907708");
            this.campoMobilePhone.SetMobilePhone(navegador).SendKeys("27995322525");
            this.campoAdressAlias.SetAdressAlias(navegador).SendKeys("jonatasd@dbserver.com.br");
            this.registerButton.GetRegisterButton(navegador).Click();

        }
    }
}