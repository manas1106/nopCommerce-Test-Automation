using AT_Assignment_Project_ManasBisen.AppHooks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace AT_Assignment_Project_ManasBisen.StepDefinitions
{
    [Binding]
    public class WishlistStepDefinitions : ApplicationHooks
    {
        [When(@"User clicks on wishlist link")]
        public void WhenUserClicksOnWishlistLink()
        {
            homePage.ClickWhishlistLink();
        }

        [Then(@"user should be able to see the wishlist page")]
        public void ThenUserShouldBeAbleToSeeTheWishlistPage()
        {
            string actualPage = PageTitle();
            string expectedResult = "nopCommerce demo store. Wishlist";
            Assert.AreEqual(expectedResult, actualPage);
        }

        [Then(@"Wishlist item count should be ""([^""]*)""")]
        public void ThenWishlistItemCountShouldBe(string count)
        {
            string actualcount = wishlistPage.GetCountOfItemsInWishlist();
            string expectedCount = count;
            Assert.IsTrue(actualcount.Contains(expectedCount));
            Console.WriteLine("Count is-" + actualcount);

        }
    }
}
