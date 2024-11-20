using AT_Assignment_Project_ManasBisen.AppHooks;
using AT_Assignment_Project_ManasBisen.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace AT_Assignment_Project_ManasBisen.StepDefinitions
{
    [Binding]
    public class User_RegistrationStepDefinitions : ApplicationHooks
    {
        [Given(@"Browser is open and User is on nopCommerce landing page")]
        public void GivenBrowserIsOpenAndUserIsOnNopCommerceLandingPage()
        {
            Console.WriteLine("Welcome");
        }

        [When(@"Click on Registration button")]
        public void WhenClickOnRegistrationButton()
        {
            landingPage.ClickRestrationLink();
            //ImplicitWait();
            //Thread.Sleep(2000);
        }

        [Then(@"Registration page should open")]
        public void ThenRegistrationPageShouldOpen()
        {
            string actualPage = PageTitle();
            string expectedPage = "nopCommerce demo store. Register";
            Assert.AreEqual(expectedPage, actualPage);
        }

        [When(@"User Enters the Personal Details as First name as ""([^""]*)"" and Last name as ""([^""]*)"" and Email as ""([^""]*)""")]
        public void WhenUserEntersThePersonalDetailsAsFirstNameAsAndLastNameAsAndEmailAs(string fName, string lName, string email)
        {
            registrationPage.EnterYourPersonalDetailsMale(fName, lName, email);
        }

        [When(@"Check the Newsletter check box")]
        public void WhenCheckTheNewsletterCheckBox()
        {
            registrationPage.CheckNewsletterCheckbox();
        }

        [When(@"Enters the password as ""([^""]*)"" and confirm password as ""([^""]*)""")]
        public void WhenEntersThePasswordAsAndConfirmPasswordAs(string password, string confirmPassword)
        {
            registrationPage.EnterPassword(password, confirmPassword);
        }


        [When(@"Click on Register button")]
        public void WhenClickOnRegisterButton()
        {
            registrationPage.ClickRegisterButton();
        }

        [Then(@"User should should be able to see message for successfull registration")]
        public void ThenUserShouldShouldBeAbleToSeeMessageForSuccessfullRegistration()
        {
            string actualResult = registrationPage.GetSuccessMessageText();
            string expectedResult = "Your registration completed";
            Assert.AreEqual(expectedResult, actualResult);
        }

        [When(@"Click on the Continue button after registration")]
        public void WhenClickOnTheContinueButtonAfterRegistration()
        {
            registrationPage.NavigateToHomepage();
        }

        [Then(@"User should be logged in and redirected to Hope Page")]
        public void ThenUserShouldBeLoggedInAndRedirectedToHopePage()
        {
            string actualResult = PageTitle();
            string expectedResult = "nopCommerce demo store";
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
