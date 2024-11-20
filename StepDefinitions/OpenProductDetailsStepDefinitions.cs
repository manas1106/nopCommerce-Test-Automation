using AT_Assignment_Project_ManasBisen.AppHooks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace AT_Assignment_Project_ManasBisen.StepDefinitions
{
    [Binding]
    public class OpenProductDetailsStepDefinitions : ApplicationHooks
    {
        [When(@"User Clicks on Product Link of product Apple MacBook Pro (.*) inch")]
        public void WhenUserClicksOnProductLinkOfProductAppleMacBookProInch(int p0)
        {
            homePage.NavigateToAppleMacBookPro13_inchPage();
        }


        [Then(@"Product Details should open")]
        public void ThenProductDetailsShouldOpen()
        {
            string actualPage = PageTitle();
            string expectedResult = "nopCommerce demo store. Apple MacBook Pro 13-inch";
            Assert.AreEqual(expectedResult, actualPage);
        }

        [Then(@"Product prrice should be displayed")]
        public void ThenProductPrriceShouldBeDisplayed()
        {
            string actualPrice = appleMacBookPro13_Inch.GetPriceOfMacBook();
            string expectedPrice = "1,800.00";
            Assert.IsTrue(actualPrice.Contains(expectedPrice));
        }
    }
}
