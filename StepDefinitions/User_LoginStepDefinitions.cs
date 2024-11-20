using AT_Assignment_Project_ManasBisen.AppHooks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace AT_Assignment_Project_ManasBisen.StepDefinitions
{
    [Binding]
    public class User_LoginStepDefinitions : ApplicationHooks
    {
        [When(@"User clicks on login button")]
        public void WhenUserClicksOnLoginButton()
        {
            landingPage.ClickLoginLink();
        }

        [Then(@"Login page should open")]
        public void ThenLoginPageShouldOpen()
        {
            string actualPage = PageTitle();
            string expectedPage = "nopCommerce demo store. Login";
            Assert.AreEqual(expectedPage, actualPage);
        }

        [When(@"User Enter email as ""([^""]*)"" and password as ""([^""]*)""")]
        public void WhenUserEnterEmailAsAndPasswordAs(string email, string password)
        {
            loginPage.EnterLoginCredentials(email, password);
        }

        [When(@"Clicks on Login button")]
        public void WhenClicksOnLoginButton()
        {
            loginPage.ClikcLoginButton();
        }

        [Then(@"User should be redirected to home page")]
        public void ThenUserShouldBeRedirectedToHomePage()
        {
            string actualHopePage = PageTitle();
            string expectedHomePage = "nopCommerce demo store";
            Assert.AreEqual(expectedHomePage, actualHopePage);
        }

        [When(@"User Enter invalid email as ""([^""]*)"" and and password as ""([^""]*)""")]
        public void WhenUserEnterInvalidEmailAsAndAndPasswordAs(string emailValue, string passwordValue)
        {
            loginPage.EnterLoginCredentials(emailValue, passwordValue);
        }

        [Then(@"User should see the error message for invalid login credentials")]
        public void ThenUserShouldSeeTheErrorMessageForInvalidLoginCredentials()
        {
            string actualErrorMessage = loginPage.GetErrorMessageOnInvalidLogin();
            string expectedErrorMessage = "Login was unsuccessful. Please correct the errors and try again.\r\nNo customer account found";
            Assert.AreEqual(expectedErrorMessage, actualErrorMessage);
            
        }

        [When(@"Click on Logout Button")]
        public void WhenClickOnLogoutButton()
        {
            homePage.ClikcLogoutLink();
        }

        [Then(@"user should be logged out successfully")]
        public void ThenUserShouldBeLoggedOutSuccessfully()
        {
            landingPage.GetLoginButton();
        }

        [Then(@"User should get error message for as ""([^""]*)""")]
        public void ThenUserShouldGetErrorMessageForAs(string error)
        {
            string actualError = loginPage.GetWrongElementErrorText();
            string expectedError = error;
            Assert.AreEqual(expectedError, actualError);
        }

        [Then(@"User should get error message as ""([^""]*)""")]
        public void ThenUserShouldGetErrorMessageAs(string error)
        {
            string actualError = loginPage.GetErrorWhenEmailIsEmpty();
            string expectedError = error;
            Assert.AreEqual(expectedError, actualError);
        }



    }
}
