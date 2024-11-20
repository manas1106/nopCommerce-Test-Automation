using AT_Assignment_Project_ManasBisen.Utility;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_Assignment_Project_ManasBisen.Pages
{
    public class AppleMacBookPro13_inch : UtilityClass
    {
        //Declaring IWebDriver
        private IWebDriver driver;

        //Add to cart button element 
        private By addToCartButtonMacBookProductElement = By.XPath("//*[@id='add-to-cart-button-4']");

        //add to wishlist button element 
        private By addToWishlistButtonMacBookProductElement = By.XPath("//*[@id='add-to-wishlist-button-4']");

        //Shopping Cart link
        private By shoppingCartLinkElement = By.XPath("//*[@class='cart-label']");

        //WhishList link
        private By whishlistLinkElemet = By.XPath("//*[@class='wishlist-label']");

        //Wishlist Item Count 
        private By countOfItemsInWishListElement = By.XPath("//*[@class='wishlist-qty']");

        //Shopping cart item count
        private By countOfItemsInShoppingCartElement = By.XPath("//*[@class='cart-qty']");

        //Success message for add to cart
        private By successMessageAddToCartElement = By.XPath("//*[@class='content']");

        //Success Message for add to wishlist
        private By successMessageAddToWishlistElement = By.XPath("//*[text()='The product has been added to your ']");

        private By closeAddToCartSuccessMessageElemet = By.XPath("//*[@class='close']");

        private By macBookProPriceElement = By.XPath("//*[@class='price-value-4']");

        //Creating Constructor 
        public AppleMacBookPro13_inch(IWebDriver driver)
        {
            this.driver = driver;
        }

        //This will AppleMacBookPro13_inch to cart 
        public void AddAppleMacBookPro13_inchToCart()
        {
            IWebElement addAppleMacBookPro13_inchToCart = driver.FindElement(addToWishlistButtonMacBookProductElement);
            addAppleMacBookPro13_inchToCart.Click();
        }

        //This will AppleMacBookPro13_inch to whishlist 
        public void AddAppleMacBookPro13_inchToWishlist()
        {
            IWebElement addAppleMacBookPro13_inchToWishlist = driver.FindElement(addToWishlistButtonMacBookProductElement);
            addAppleMacBookPro13_inchToWishlist.Click();
        }

        //this will get return count of ites in whishlist -> but like this > (2)
        public string GetCountOfItemsInWishlist()
        {
            IWebElement getCountOfItemsInWishlist = driver.FindElement(countOfItemsInWishListElement);
            return getCountOfItemsInWishlist.Text;
        }

        //this will get return count of ites in cart -> but like this > (2)
        public string GetCountOfItemsInShoppingCart()
        {
            IWebElement getCountOfItemsInShoppingCart = driver.FindElement(countOfItemsInShoppingCartElement);
            return getCountOfItemsInShoppingCart.Text;
        }

        //this will click on shopping cart link
        public ShoppingCartPage ClickOnShoppingCartLink()
        {
            IWebElement clickOnShoppingCartLink = driver.FindElement(shoppingCartLinkElement);
            clickOnShoppingCartLink.Click();
            return new ShoppingCartPage(driver);
        }

        //this will click on whishlist link
        public WishlistPage ClickOnWishlistLink()
        {
            IWebElement clickOnWishlistLink = driver.FindElement(whishlistLinkElemet);
            clickOnWishlistLink.Click();
            return new WishlistPage(driver);
        }

        //this will get success message for add to cart 
        public string GetSuccessMessageAddtoCart()
        {
            IWebElement getSuccessMessageAddtoCart = driver.FindElement(successMessageAddToCartElement);
            return getSuccessMessageAddtoCart.Text;
        }

        //this will get success message for add to wishlist 
        public string GetSuccessMessageAddtoWishList()
        {
            IWebElement getSuccessMessageAddtoWishList = driver.FindElement(successMessageAddToWishlistElement);
            return getSuccessMessageAddtoWishList.Text;
        }

        //close the success message 
        public void CloseAddToCartSuccessmessage()
        {
            IWebElement closeAddToCartSuccessmessage = driver.FindElement(closeAddToCartSuccessMessageElemet);
            closeAddToCartSuccessmessage.Click();
        }

        //Get price of product
        public string GetPriceOfMacBook()
        {
            IWebElement getPriceOfMacBook = driver.FindElement(macBookProPriceElement);
            return getPriceOfMacBook.Text;
        }

    }
}
