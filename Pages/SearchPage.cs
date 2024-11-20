using AT_Assignment_Project_ManasBisen.Utility;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_Assignment_Project_ManasBisen.Pages
{
    public class SearchPage : UtilityClass
    {
        //Declaring IWebDriver
        private IWebDriver driver;

        //Searched Product 
        private By searchedProductElement = By.XPath("//*[text()='Flower Girl Bracelet']");

        //Invalid Product search 
        private By invalidSearchedProductElement = By.XPath("//*[text()='No products were found that matched your criteria.']");

        //Creating Constructor 
        public SearchPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        //This will get search result 
        public string GetSerchedProduct()
        {
            IWebElement getSerchedProduct = driver.FindElement(searchedProductElement);
            return getSerchedProduct.Text;
        }

        //This will get message for invalid product search 
        public string GetMessageForProductNotDound()
        {
            IWebElement getMessageForProductNotDound = driver.FindElement(invalidSearchedProductElement);
            return getMessageForProductNotDound.Text;
        }


    }
}
