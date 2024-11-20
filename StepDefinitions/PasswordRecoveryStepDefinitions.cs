using AT_Assignment_Project_ManasBisen.AppHooks;
using AT_Assignment_Project_ManasBisen.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace AT_Assignment_Project_ManasBisen.StepDefinitions
{
    [Binding]
    public class PasswordRecoveryStepDefinitions : ApplicationHooks
    {
        [When(@"User clicks on Login Link")]
        public void WhenUserClicksOnLoginLink()
        {
            landingPage.ClickLoginLink();
        }

        [Then(@"User should be redirected to Login Page")]
        public void ThenUserShouldBeRedirectedToLoginPage()
        {
            string actualPage = PageTitle();
            string expectedPage = "nopCommerce demo store. Login";
            Assert.AreEqual(expectedPage, actualPage);
        }

        [When(@"User clicks on Forgot Password link")]
        public void WhenUserClicksOnForgotPasswordLink()
        {
            loginPage.ClickForgotPasswordLink();
        }

        [Then(@"User should be redirected to Password Recovery Page")]
        public void ThenUserShouldBeRedirectedToPasswordRecoveryPage()
        {
            string actualPage = PageTitle();
            string expectedPage = "nopCommerce demo store. Password Recovery";
            Assert.AreEqual(expectedPage, actualPage);

        }

        [When(@"User Enter recovery Email as ""([^""]*)""")]
        public void WhenUserEnterRecoveryEmailAs(string emailValue)
        {
            passwordRecoveryPage.EnterEmailForPasswordRecovery(emailValue);
        }

        [When(@"Clicks Recover button")]
        public void WhenClicksRecoverButton()
        {
            passwordRecoveryPage.ClickRecoverButton();
        }

        [Then(@"User should see the be able to see the message for recovery email sent")]
        public void ThenUserShouldSeeTheBeAbleToSeeTheMessageForRecoveryEmailSent()
        {
            string actualMessage = passwordRecoveryPage.GetConfirmationMessage();
            string expectedMessage = "Email with instructions has been sent to you.";
            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [Then(@"User should see the be able to see the message for recovery email not found")]
        public void ThenUserShouldSeeTheBeAbleToSeeTheMessageForRecoveryEmailNotFound()
        {
            string actualMessage = passwordRecoveryPage.GetEmailErrorMessage();
            string expectedMessage = "Email not found.";
            Assert.AreEqual(actualMessage, expectedMessage);

        }

    }
}
