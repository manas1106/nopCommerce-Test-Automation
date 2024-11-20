using AT_Assignment_Project_ManasBisen.Utility;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AT_Assignment_Project_ManasBisen.Pages
{
    public class HomePage : UtilityClass
    {
        //Declaring IWebDriver
        private IWebDriver driver;

        //creating elements 
        //My Account button
        private By myAccountLinkElement = By.XPath("//*[text()='My account']");

        //Log out Button
        private By logoutLinkElement = By.XPath("//*[text()='Log out']");

        //Wishlist button
        private By wichlistLinkElement = By.XPath("//*[@class='wishlist-label']");

        //Shopping Cart button
        private By shoppingCartLinkElement = By.XPath("//*[@class='cart-label']");

        //Macbook product link element 
        private By clickMacBookProductElement = By.XPath("//*[text()='Apple MacBook Pro 13-inch']");

        //Search Bar textbox 
        private By searchBarTextboxElement = By.XPath("//*[@id='small-searchterms']");

        //Search Button
        private By searchButtonElement = By.XPath("//*[@class='button-1 search-box-button']");

        //Creating Constructor 
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        //Custom Methods 
        //this will click on logout button on home page
        public LandingPage ClikcLogoutLink()
        {
            IWebElement clickLogoutLink = driver.FindElement(logoutLinkElement);
            clickLogoutLink.Click();
            return new LandingPage(driver);
        }

        //this will click on My account link element 
        public AccountPage ClickMyAccountLink()
        {
            IWebElement clickMyAccountLink = driver.FindElement(myAccountLinkElement);
            clickMyAccountLink.Click();
            return new AccountPage(driver);
        }

        //This will redirect user to Wishlist page 
        public WishlistPage ClickWhishlistLink()
        {
            IWebElement clickWhishlistLink = driver.FindElement(wichlistLinkElement);
            clickWhishlistLink.Click();
            return new WishlistPage(driver);
        }

        //This will redirect user to shopping cart page 
        public ShoppingCartPage ClickShoppingCartLink()
        {
            IWebElement clickShoppingCartLink = driver.FindElement(shoppingCartLinkElement);
            clickShoppingCartLink.Click();
            return new ShoppingCartPage(driver);
        }

        //this will open the Apple MacBook Pro 13-inch page 
        public AppleMacBookPro13_inch NavigateToAppleMacBookPro13_inchPage()
        {
            IWebElement navigateToAppleMacBookPro13_inch = driver.FindElement(clickMacBookProductElement);
            navigateToAppleMacBookPro13_inch.Click();
            return new AppleMacBookPro13_inch(driver);
        }

        //This will take product to search 
        public void EnterProductToSearch(string prodcuctValue)
        {
            IWebElement enterProductToSearch = driver.FindElement(searchBarTextboxElement);
            enterProductToSearch.SendKeys(prodcuctValue);
        }

        //This will click on search button
        public SearchPage ClickProductSearchButton()
        {
            IWebElement clickProductSearchButton = driver.FindElement(searchButtonElement);
            clickProductSearchButton.Click();
            return new SearchPage(driver);
        }
    }
}
