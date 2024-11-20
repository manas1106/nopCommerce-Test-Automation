using AT_Assignment_Project_ManasBisen.Utility;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_Assignment_Project_ManasBisen.Pages
{
    public class LandingPage : UtilityClass
    {
        //Declaring IWebDriver
        private IWebDriver driver;

        //creating elements 
        //Registration button
        private By registrationLinkElement = By.XPath("//*[@class='ico-register']");

        //Login Button
        private By loginLinkElement = By.XPath("//*[@class='ico-login']");

        //Currency dropdown
        private By currencyChnageDropdown = By.XPath("");

        //creating Constructor 
        public LandingPage(IWebDriver driver) 
        {
            this.driver = driver;
        }

        //creating custom methods 
        //this will click on register on landing page
        public RegistrationPage ClickRestrationLink()
        {
            IWebElement clickRegistrationLink = driver.FindElement(registrationLinkElement);
            clickRegistrationLink.Click();
            return new RegistrationPage(driver);
        }

        //this will click on login on landing page
        public LoginPage ClickLoginLink()
        {
            IWebElement clickLoginLink = driver.FindElement(loginLinkElement);
            clickLoginLink.Click();
            return new LoginPage(driver);
        }

        //this will open currency chnage dropdown
        public void ChangeCurrencyDropdown()
        {
            IWebElement clickChnageCurrencyDropdown = driver.FindElement(currencyChnageDropdown);
            clickChnageCurrencyDropdown.Click();
        }

        public string GetLoginButton()
        {
            IWebElement getLoginbutton = driver.FindElement(loginLinkElement);
            return getLoginbutton.Text;
        }

    }
}
