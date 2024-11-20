using AT_Assignment_Project_ManasBisen.Utility;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_Assignment_Project_ManasBisen.Pages
{
    public class ShoppingCartPage : UtilityClass
    {
        //Declaring IWebDriver
        private IWebDriver driver;

        //No need to create elements for now
        private By removeProductFromCartElement = By.XPath("//*[@class='remove-btn']");

        private By noProductInCartElement = By.XPath("//*[@class='no-data']");

        //Shopping cart item count
        private By countOfItemsInShoppingCartElement = By.XPath("//*[@class='cart-qty']");

        //Creating Constructor 
        public ShoppingCartPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        //No need to create any custome methods for now
        public void RemoveProductFromCart()
        {
            IWebElement RemoveProductFromCart = driver.FindElement(removeProductFromCartElement);
            RemoveProductFromCart.Click();
        }

        public string GetMessageForEmptyCart()
        {
            IWebElement getMessageForEmptyCart = driver.FindElement(noProductInCartElement);
            return getMessageForEmptyCart.Text;
        }

        //this will get return count of ites in cart -> but like this > (2)
        public string GetCountOfItemsInShoppingCart()
        {
            IWebElement getCountOfItemsInShoppingCart = driver.FindElement(countOfItemsInShoppingCartElement);
            return getCountOfItemsInShoppingCart.Text;
        }
    }
}
