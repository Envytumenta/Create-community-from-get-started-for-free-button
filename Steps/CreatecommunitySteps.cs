using CreateCommunityFromGetStartedFreeButton.Hooks;
using CreateCommunityFromGetStartedFreeButton.PageObject;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace CreateCommunityFromGetStartedFreeButton.Steps
{
    [Binding]
    public class CreatecommunitySteps
    {
        public IWebDriver driver = WebHook.driver;

        CreateCmmunityPage createCmmunityPage = new CreateCmmunityPage();


        [Given(@"that I am a user on Giftrete website \(www\.giftrete\.com\)")]
        public void GivenThatIAmAUserOnGiftreteWebsiteWww_Giftrete_Com()
        {
            driver.Navigate().GoToUrl("https://www.qa2020.giftrete.com/");
        }
        
        [When(@"user click on get started for free button")]
        public void WhenUserClickOnGetStartedForFreeButton()
        {
            createCmmunityPage.ClickGetFreeButton();
        }
        
        [When(@"user click on register")]
        public void WhenUserClickOnRegister()
        {
            createCmmunityPage.Register();
        }
        
        [When(@"user enter email address")]
        public void WhenUserEnterEmailAddress()
        {
            createCmmunityPage.EnterEmailAddress();
        }
        
        [When(@"user enter first name")]
        public void WhenUserEnterFirstName()
        {
            createCmmunityPage.FirstName();
        }
        
        [When(@"user enter last name")]
        public void WhenUserEnterLastName()
        {
            createCmmunityPage.LastName();
        }
        
        [When(@"user enter phone number")]
        public void WhenUserEnterPhoneNumber()
        {
            createCmmunityPage.PhoneNumber();
        }
        
        [When(@"user enter password")]
        public void WhenUserEnterPassword()
        {
            createCmmunityPage.EnterPassword();
        }

        [When(@"user re-enter password")]
        public void WhenUserRe_EnterPassword()
        {
            createCmmunityPage.ReEnterPassword();
        }



        [When(@"user Click on register now button")]
        public void WhenUserClickOnRegisterNowButton()
        {
            createCmmunityPage.RegisterNow();
        }
        
        [Then(@"user should be logged in")]
        public void ThenUserShouldBeLoggedIn()
        {
            
        }
    }
}
