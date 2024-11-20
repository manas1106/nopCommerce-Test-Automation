using AT_Assignment_Project_ManasBisen.AppHooks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace AT_Assignment_Project_ManasBisen.StepDefinitions
{
    [Binding]
    public class MyAccountStepDefinitions : ApplicationHooks
    {
        [When(@"User Clicks on MyAccount link")]
        public void WhenUserClicksOnMyAccountLink()
        {
            homePage.ClickMyAccountLink();
            ImplicitWait();
        }

        [Then(@"Then User should be redirected to MyAccount Page")]
        public void ThenThenUserShouldBeRedirectedToMyAccountPage()
        {
            string actulPage = PageTitle();
            string expectedPage = "nopCommerce demo store";
            Assert.AreEqual(expectedPage, actulPage);
            Console.WriteLine("User is on Account page");
        }

        [When(@"Enter the company name as ""([^""]*)""")]
        public void WhenEnterTheCompanyNameAs(string company)
        {
            account.EnterCompanyName(company);
        }

        [When(@"Click on Save Button")]
        public void WhenClickOnSaveButton()
        {
            account.ClickSaveButton();
        }

        [Then(@"Comapany Name should be updated and User should be able to see the success message")]
        public void ThenComapanyNameShouldBeUpdatedAndUserShouldBeAbleToSeeTheSuccessMessage()
        {
            account.GetSuccessMessageInfoUpdate();
            Console.WriteLine("Company Name Added");
        }

        [When(@"when User click on Order link")]
        public void WhenWhenUserClickOnOrderLink()
        {
            account.ClickOnOrderLink();
        }

        [Then(@"Then order list should be displayed")]
        public void ThenThenOrderListShouldBeDisplayed()
        {
            string actualOrders = account.GetOrderList();
            string expectedOrders = "No orders";
            Assert.AreEqual(expectedOrders, actualOrders);
            Console.WriteLine("Order ->" + actualOrders);
        }

        [When(@"when User click on Rewards Point link")]
        public void WhenWhenUserClickOnRewardsPointLink()
        {
            account.ClickOnRewardPointsLink();
        }

        [Then(@"Then rewards Points should be displayed as ""([^""]*)""")]
        public void ThenThenRewardsPointsShouldBeDisplayedAs(string points)
        {
            string actualRewardPoints = account.GetRewardPoints();
            string expectedRewardPoints = points;
            Assert.AreEqual(expectedRewardPoints, actualRewardPoints);
            Console.WriteLine("Reward Point -" + actualRewardPoints);
        }

    }
}
