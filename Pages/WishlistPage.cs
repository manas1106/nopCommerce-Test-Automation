using AT_Assignment_Project_ManasBisen.Utility;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_Assignment_Project_ManasBisen.Pages
{
    public class WishlistPage : UtilityClass
    {
        //Declaring IWebDriver
        private IWebDriver driver;

        //Shopping cart item count
        private By countOfItemsInWishListElement = By.XPath("//*[@class='wishlist-qty']");

        //Creating Constructor 
        public WishlistPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        //this will get return count of ites in whishlist -> but like this > (num)
        public string GetCountOfItemsInWishlist()
        {
            IWebElement getCountOfItemsInWishlist = driver.FindElement(countOfItemsInWishListElement);
            return getCountOfItemsInWishlist.Text;
        }
    }
}
