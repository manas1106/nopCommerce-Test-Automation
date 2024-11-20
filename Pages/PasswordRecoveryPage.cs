using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_Assignment_Project_ManasBisen.Pages
{
    public class PasswordRecoveryPage
    {
        //Declaring IWebDriver
        private IWebDriver driver;

        //Enter Email on Password Recovery screen
        private By enterRecoveryEmailElement = By.XPath("//*[@class='email']");

        //Recover Button
        private By recoverButtonElement = By.XPath("//*[@name='send-email']");

        //Confirmation Message 
        private By passwordRecoveryEmailConfirmationElement = By.XPath("//*[text()='Email with instructions has been sent to you.']");

        //Message for incorrect email
        private By emailNotFoundMessageElement = By.XPath("//*[text()='Email not found.']");

        //Creating Constructor 
        public PasswordRecoveryPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        //Custom Methods 
        //This will enter Email address for recovery 
        public void EnterEmailForPasswordRecovery(string emailValue)
        {
            IWebElement enterEmailForPasswordRecovery = driver.FindElement(enterRecoveryEmailElement);
            enterEmailForPasswordRecovery.SendKeys(emailValue);
        }

        //this will click on recover button
        public void ClickRecoverButton()
        {
            IWebElement clickRecoverButton = driver.FindElement(recoverButtonElement);
            clickRecoverButton.Click();
        }

        //this will get the confirmation message
        public string GetConfirmationMessage()
        {
            IWebElement getConfirmationMessage = driver.FindElement(passwordRecoveryEmailConfirmationElement);
            return getConfirmationMessage.Text;
        }

        //this will get the error message
        public string GetEmailErrorMessage()
        {
            IWebElement getEmailErrorMessage = driver.FindElement(emailNotFoundMessageElement);
            return getEmailErrorMessage.Text;
        }
    }
}
