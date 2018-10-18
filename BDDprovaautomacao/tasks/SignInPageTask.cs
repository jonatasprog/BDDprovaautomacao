using BDDprovaautomacao.pageobjects;
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

        public void cadastrarEmail()
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

            this.campoCadastrarEmail.setEmailAdress(this.navegador).SendKeys(saltStr + "@gmail.com");

        }

        public void clicarBotao()
        {
            this.buttonCreateAccount.getSubmitCreateButton(navegador).Click();
        }

        public void preencherFormulario()
        {
            this.radioButton.getRadioButton(navegador).Click();
            this.campoCustomerFirstName.setFirstCustomerName(navegador).SendKeys("Jônatas");
            this.campoCustomerLastName.setLastCustomerName(navegador).SendKeys("Deorce");
            this.campoPassword.setPasswd(navegador).SendKeys("DbServer123456");
            this.comboDay.comboDay(navegador).Click();
            new SelectElement(comboDay.comboDay(navegador)).SelectByValue("3");            
            this.comboMonth.comboMonth(navegador).Click();
            new SelectElement(comboMonth.comboMonth(navegador)).SelectByText("March ");            
            this.comboYear.comboYear(navegador).Click();
            new SelectElement(comboYear.comboYear(navegador)).SelectByText("1989  ");
            this.campoCompany.setCompany(navegador).SendKeys("DbServer");
            this.campoAdress.setAdress(navegador).SendKeys("Avenida Ipiranga, número 17");
            this.campoAdress2.setAdress2(navegador).SendKeys("Próximo a PUCRS");
            this.campoCity.setCity(navegador).SendKeys("Porto Alegre");
            this.comboState.comboState(navegador).Click();            
            new SelectElement(comboState.comboState(navegador)).SelectByText("Alabama");
            this.campoPostalCode.setPostalCode(navegador).SendKeys("29150");
            this.comboCountry.setComboCountry(navegador).Click();            
            new SelectElement(comboCountry.setComboCountry(navegador)).SelectByText("United States");
            this.campoAdditionalInformation.setAdditionalInformation(navegador).SendKeys("Moro no Brasil, porém este form só aceita Estados Unidos no ComboBox!");
            this.campoHomePhone.setHomePhone(navegador).SendKeys("2730907708");
            this.campoMobilePhone.setMobilePhone(navegador).SendKeys("27995322525");
            this.campoAdressAlias.setAdressAlias(navegador).SendKeys("jonatasd@dbserver.com.br");
            this.registerButton.getRegisterButton(navegador).Click();


        }
    }
}
