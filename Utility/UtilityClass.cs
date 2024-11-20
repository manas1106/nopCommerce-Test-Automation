using AT_Assignment_Project_ManasBisen.Config;
using OpenQA.Selenium.Chrome;
using System;

namespace AT_Assignment_Project_ManasBisen.Utility
{
    public class UtilityClass : ConfigClass
    {
        public void LaunchBrowser(string browser)
        {
            switch (browser) 
            {
                case "CHROME":
                    driver = new ChromeDriver(chromeDriverPath);
                    break;

                case "EDGE":
                    driver = new ChromeDriver(chromeDriverPath);
                    break;
            }
        }

        public void LaunchApp()
        {
            driver.Url = url;
        }

        public void CloseBrowser()
        {
            driver.Quit();
        }

        public void BrowserMaximize()
        {
            driver.Manage().Window.Maximize();
        }

        public void PageLoad()
        {
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(pageLoadTime);
        }

        //This method is used to provide the implicit wait
        public void ImplicitWait()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(implicitWaitTime);
        }

        public string PageTitle() 
        {
            return driver.Title;
        }
    }
}
