//Application hooks in a SpecFlow hybrid framework are methods that execute automatically before or after specific test events like scenarios or features. 
//They provide a centralized way to perform common setup and teardown tasks, making your tests more efficient and maintainable.
using AT_Assignment_Project_ManasBisen.Pages;
using AT_Assignment_Project_ManasBisen.Utility;
using System.Threading;
using TechTalk.SpecFlow;

namespace AT_Assignment_Project_ManasBisen.AppHooks
{
    //ApplicationHooks Class is same as Base class
    public class ApplicationHooks : UtilityClass 
    {
        public AccountPage account;
        public AppleMacBookPro13_inch appleMacBookPro13_Inch;
        public HomePage homePage;
        public LandingPage landingPage;
        public LoginPage loginPage;
        public RegistrationPage registrationPage;
        public ShoppingCartPage shoppingCartPage;
        public WishlistPage wishlistPage;
        public PasswordRecoveryPage passwordRecoveryPage;
        public SearchPage searchPage;

        [BeforeScenario]
        public void BeforeScenario()
        {
            LaunchBrowser("CHROME");
            Thread.Sleep(1500);
            BrowserMaximize();
            Thread.Sleep(1500);
            LaunchApp();
            Thread.Sleep(1500);

            account = new AccountPage(driver);
            appleMacBookPro13_Inch = new AppleMacBookPro13_inch(driver);
            homePage = new HomePage(driver);
            landingPage = new LandingPage(driver);
            loginPage = new LoginPage(driver);
            registrationPage = new RegistrationPage(driver);
            shoppingCartPage = new ShoppingCartPage(driver);
            wishlistPage = new WishlistPage(driver);
            passwordRecoveryPage = new PasswordRecoveryPage(driver);
            searchPage = new SearchPage(driver);

        }

        [AfterScenario]
        public void AfterScenario()
        {
            Thread.Sleep(1500);
            CloseBrowser();
        }

    }
}

