using AT_Assignment_Project_ManasBisen.AppHooks;
using AT_Assignment_Project_ManasBisen.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace AT_Assignment_Project_ManasBisen.StepDefinitions
{
    [Binding]
    public class SearchProductStepDefinitions : ApplicationHooks
    {
        [When(@"User Enter the Product Name <""([^""]*)""> in Search textbox")]
        public void WhenUserEnterTheProductNameInSearchTextbox(string product)
        {
            homePage.EnterProductToSearch(product);
        }

        [When(@"Click Search button")]
        public void WhenClickSearchButton()
        {
            homePage.ClickProductSearchButton();
        }

        [Then(@"User should see the searched product or result as <""([^""]*)"">")]
        public void ThenUserShouldSeeTheSearchedProductOrResultAs(string searchResult)
        {
            string actualPage = PageTitle();
            string expectedPage = "nopCommerce demo store. Search";
            Assert.AreEqual(expectedPage, actualPage);

            string actualSearchedProduct = searchPage.GetSerchedProduct();
            string expectedSearchedProduct = searchResult;
            Assert.AreEqual(actualSearchedProduct, expectedSearchedProduct);
        }
    }
}
