using CreateCommunityFromGetStartedFreeButton.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CreateCommunityFromGetStartedFreeButton.PageObject
{
    class CreateCmmunityPage
    {
        public IWebDriver driver;

        public CreateCmmunityPage()
        {
            driver = WebHook.driver;

        }
        private By GetFreeButton = By.CssSelector("body>section.nav-header-sec.w-100.relative>div.vh-100.vh-60-pro.vh-85-m.vh-85-pro.flex.db-ns.bg-black.w-100.relative>div>div>a");
        public void ClickGetFreeButton()
        {
            driver.FindElement(GetFreeButton).Click();
        }
        private By register = By.Id("nav-register-tab");

        public void Register()
        {
            driver.FindElement(register).Click();
        }

        private By enterEmailAddress = By.Id("email");
            
        public void EnterEmailAddress() 
        {
            Thread.Sleep(10000);
            driver.FindElement(enterEmailAddress).SendKeys("mantiti1@mail.com");

        }

        private By firstName = By.Id("first_name");

        public void FirstName()
        {
            driver.FindElement(firstName).SendKeys("kingsley");
        }

        private By lastName = By.Id("last_name");

        public void LastName()
        {
            driver.FindElement(lastName).SendKeys("baifra");
        }

        private By phoneNumber = By.Id("mobile");

        public void PhoneNumber()
        {
            driver.FindElement(phoneNumber).SendKeys("01902123454");
        }
        

        private By enterPassword = By.Id("password");

        public void EnterPassword()
        {
            driver.FindElement(enterPassword).SendKeys("Asernal1234");

        }

        private By reEnterPassword = By.Id("confirm_password");

        public void ReEnterPassword()
        {
            driver.FindElement(reEnterPassword).SendKeys("Asernal1234");
        }

        private By registerNow = By.Id("btn_register");

        public void RegisterNow()
        {
            driver.FindElement(registerNow).Click();
        }

       

        
        
            
        




    }
}
