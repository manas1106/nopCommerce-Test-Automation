//A Config class in a SpecFlow hybrid framework is a utility class used to store and manage configuration settings for automated tests. 
//It centralizes configuration, improves readability, enhances reusability, and simplifies maintenance.
using OpenQA.Selenium;

namespace AT_Assignment_Project_ManasBisen.Config
{
    public class ConfigClass
    {
        public IWebDriver driver;

        public string chromeDriverPath = @"Provide the path of chrome driver where it is placed";
        public string edgeDriverPath = @"Provide the path of chrome driver where it is placed";

        public string url = "https://demo.nopcommerce.com/";

        public int pageLoadTime = 10;
        public int implicitWaitTime = 10;

    }
}
