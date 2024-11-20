using AT_Assignment_Project_ManasBisen.AppHooks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace AT_Assignment_Project_ManasBisen.StepDefinitions
{
    [Binding]
    public class ShoppingCartStepDefinitions : ApplicationHooks
    {
        [When(@"User clicks on shopping cart link")]
        public void WhenUserClicksOnShoppingCartLink()
        {
            homePage.ClickShoppingCartLink();
        }

        [Then(@"user should be able to see the shopping cart page")]
        public void ThenUserShouldBeAbleToSeeTheShoppingCartPage()
        {
            string actualPage = PageTitle();
            string expectedResult = "nopCommerce demo store. Shopping Cart";
            Assert.AreEqual(expectedResult, actualPage);
        }

        [Then(@"Shopping cart item count should be ""([^""]*)""")]
        public void ThenShoppingCartItemCountShouldBe(string count)
        {
            string actualCount = shoppingCartPage.GetCountOfItemsInShoppingCart();
            string expectedCunt = count;
            Assert.IsTrue(actualCount.Contains(expectedCunt));
            Console.WriteLine("Count is-" + actualCount);
        }
    }
}
