using AT_Assignment_Project_ManasBisen.Utility;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace AT_Assignment_Project_ManasBisen.Pages
{
    public class AccountPage : UtilityClass
    {
        //Declaring IWebDriver
        private IWebDriver driver;

        //No need to create elements for now
        private By companyNameTextboxElement = By.XPath("//*[@id='Company']");

        private By confirmationMessageInfoUpdate = By.XPath("//*[text()='The customer info has been updated successfully.']");

        private By saveButtonElement = By.XPath("//*[@id='save-info-button']");

        //order button 
        private By orderLinkElement = By.XPath("//*[@class='customer-orders inactive']");

        //Orders avilable 
        private By orderAvailableToShow = By.XPath("//*[text()='No orders']");

        //Reward point button 
        private By rewardPointLinkElement = By.XPath("//*[@class='reward-points active']");

        //Orders avilable 
        private By rewardPointAvailableToShow = By.XPath("//*[text()='Your current balance is 0 reward points ($0.00).']");


        //Creating Constructor 
        public AccountPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        //No need to create any custome methods for now
        public void EnterCompanyName(string company)
        {
            IWebElement enterCompanyName = driver.FindElement(companyNameTextboxElement);
            enterCompanyName.SendKeys(company);
        }

        public string GetSuccessMessageInfoUpdate()
        {
            IWebElement getSuccessMessageInfoUpdate = driver.FindElement(confirmationMessageInfoUpdate);
            return getSuccessMessageInfoUpdate.Text;
        }

        public void ClickSaveButton()
        {
            IWebElement clickSaveButton = driver.FindElement(saveButtonElement);
            clickSaveButton.Click();
        }

        public void ClickOnOrderLink()
        {
            IWebElement clickOnOrderLink = driver.FindElement(orderLinkElement);
            clickOnOrderLink.Click();
        }

        public string GetOrderList()
        {
            IWebElement getOrderList = driver.FindElement(orderAvailableToShow);
            return getOrderList.Text;
        }

        public void ClickOnRewardPointsLink()
        {
            IWebElement clickOnRewardPointsLink = driver.FindElement(rewardPointLinkElement);
            clickOnRewardPointsLink.Click();
        }

        public string GetRewardPoints()
        {
            IWebElement getRewardPoints = driver.FindElement(rewardPointAvailableToShow);
            return getRewardPoints.Text;
        }
    }
}
