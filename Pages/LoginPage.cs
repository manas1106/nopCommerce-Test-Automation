using AT_Assignment_Project_ManasBisen.Utility;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_Assignment_Project_ManasBisen.Pages
{
    public class LoginPage : UtilityClass
    {
        //Declaring IWebDriver
        private IWebDriver driver;

        //creating elements 
        //Email textbox element 
        private By emailTextBoxElement = By.XPath("//*[@class='email']");

        //password TextBox Element
        private By passwordTextBoxElement = By.XPath("//*[@class='password']");

        //login Button Element
        private By loginButtonElement = By.XPath("//*[@class='button-1 login-button']");

        //invalid login validation message 
        private By errorMessageAfterInvalidLoginElement = By.XPath("//*[text()='Login was unsuccessful. Please correct the errors and try again.']");

        //Forgot Password link element
        private By forgotPasswordLinkElement = By.XPath("//*[contains(text(),'Forgot password?')]");

        //Enter Email address error 
        private By enterEmailErrorElement = By.XPath("//*[text()='Please enter your email']");

        //wrong Email error 
        private By wrongEmailErrorElement = By.XPath("//*[text()='Wrong email']");

        //Creating Constructor 
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        //Custom Method 
        //Method to enter login credentials  
        public void EnterLoginCredentials(string emailValue, string passwordValue)
        {
            IWebElement enterEmail = driver.FindElement(emailTextBoxElement);
            enterEmail.SendKeys(emailValue);
            IWebElement enterPassword = driver.FindElement(passwordTextBoxElement);
            enterPassword.SendKeys(passwordValue);
        }

        //Method to click on Login Button
        public HomePage ClikcLoginButton()
        {
            IWebElement clikcLoginButton = driver.FindElement(loginButtonElement);
            clikcLoginButton.Click();
            return new HomePage(driver);
        }

        //This will get error message after invalid login credentials 
        public string GetErrorMessageOnInvalidLogin()
        {
            IWebElement getErrorMessageOnInvalidLogin = driver.FindElement(errorMessageAfterInvalidLoginElement);
            return getErrorMessageOnInvalidLogin.Text;
        }

        //this will click on forgot password link
        public PasswordRecoveryPage ClickForgotPasswordLink()
        {
            IWebElement clickForgotPasswordLink = driver.FindElement(forgotPasswordLinkElement);
            clickForgotPasswordLink.Click();
            return new PasswordRecoveryPage(driver);
        }

        public string GetErrorWhenEmailIsEmpty()
        {
            IWebElement getErrorWhenEmailIsEmpty = driver.FindElement(enterEmailErrorElement);
            return getErrorWhenEmailIsEmpty.Text;
        }

        public string GetWrongElementErrorText()
        {
            IWebElement getWrongElementErrorText = driver.FindElement(wrongEmailErrorElement);
            return getWrongElementErrorText.Text;
        }

    }
}
