using AT_Assignment_Project_ManasBisen.Utility;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace AT_Assignment_Project_ManasBisen.Pages
{
    public class RegistrationPage : UtilityClass
    {
        //Declaring IWebDriver
        private IWebDriver driver;

        //creating elements 
        //Gender Male Radio Button
        private By maleRadioElement = By.XPath("//*[@id='gender-male']");

        //Gender Female Radio Button
        private By femaleRadioElement = By.XPath("//*[@id='gender-female']");

        //FirstName text box
        private By firstNameTextBoxElement = By.XPath("//*[@name='FirstName']");


        //LastName text box 
        private By lastNameTextBoxElement = By.XPath("//*[@id='LastName']");

        //email text box
        private By emailTextboxElement = By.XPath("//*[@id='Email']");

        //Newsletter checkbox 
        private By newsletterCheckboxElement = By.XPath("//*[@id='Newsletter']");

        //Password textbox 
        private By passwordTextboxElement = By.XPath("//*[@name='Password']");

        //Password textbox 
        private By condirmPasswordTextboxElement = By.XPath("//*[@name='ConfirmPassword']");

        //Registor Button
        private By registerButtonElement = By.XPath("//*[@id='register-button']");

        //Registration successfull message 
        private By successMessageElement = By.XPath("//*[text()='Your registration completed']");

        //Continue button after successfull registration 
        private By continueButtonAfterRegistration = By.XPath("//*[text()='Continue']");

        //Creating Constructor 
        public RegistrationPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        //Custom Methods
        //Method to Enter Your Persoanl Details 
        public void EnterYourPersonalDetailsMale(string firstnameValue, string lastnameValue, string emailValue)
        {
            IWebElement maleRadiobutton = driver.FindElement(maleRadioElement);
            maleRadiobutton.Click();

            IWebElement firstnameTextbox = driver.FindElement(firstNameTextBoxElement);
            firstnameTextbox.SendKeys(firstnameValue);

            IWebElement lastnameTextbox = driver.FindElement(lastNameTextBoxElement);
            lastnameTextbox.SendKeys(lastnameValue);

            IWebElement emailTextbox = driver.FindElement(emailTextboxElement);
            emailTextbox.SendKeys(emailValue);
        }

        //Method to check newsletter checkbox 
        public void CheckNewsletterCheckbox()
        {
            IWebElement newsletterCheckbox = driver.FindElement(newsletterCheckboxElement);
            newsletterCheckbox.Click();
        }

        //Method to enter Password
        public void EnterPassword(string passwordValue, string confirmPasswordValue)
        {
            IWebElement passwordTextbox = driver.FindElement(passwordTextboxElement);
            passwordTextbox.SendKeys(passwordValue);
            IWebElement confirmPasswordTextbox = driver.FindElement(condirmPasswordTextboxElement);
            confirmPasswordTextbox.SendKeys(confirmPasswordValue);
        }

        //Method to click register button
        public void ClickRegisterButton()
        {
            IWebElement clickRegisterButton = driver.FindElement(registerButtonElement);
            clickRegisterButton.Click();
        }

        //this will fetch the success message for successfull registration
        public string GetSuccessMessageText()
        {
            IWebElement getSuccessMessageText = driver.FindElement(successMessageElement);
            return getSuccessMessageText.Text;
        }

        //Method to navigate to Homepage after successfull login
        public HomePage NavigateToHomepage()
        {
            IWebElement continueButtonOnRegisterPage = driver.FindElement(continueButtonAfterRegistration);
            continueButtonOnRegisterPage.Click();
            return new HomePage(driver);
        }

    }
}
