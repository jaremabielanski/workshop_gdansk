using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTesty
{

    public class TestBase
    {

        public IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            var waitTime = new System.TimeSpan(0, 0, 1);
            driver.Manage().Timeouts().ImplicitWait = waitTime;
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

    }
}
