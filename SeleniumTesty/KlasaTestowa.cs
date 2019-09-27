using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTesty
{
    [TestFixture]
    public class KlasaTestowa
    {

        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            var waitTime = new System.TimeSpan(0, 0, 1);
            driver.Manage().Timeouts().ImplicitWait = waitTime;
        }

        [Test]
        public void TShirts()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");

            var categoryHeader = driver.FindElement(By.CssSelector("ul.sf-menu > li > a[title='T-shirts']"));
            categoryHeader.Click();

            var productCounter = driver.FindElement(By.CssSelector(".heading-counter"));
            var webElements = driver.FindElements(By.CssSelector("div.product-container"));
            string cntEl = webElements.Count.ToString();
            
            StringAssert.Contains(cntEl, productCounter.Text);
        }

        [Test]
        public void Kobiety()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");

            var categoryHeader = driver.FindElement(By.CssSelector("ul.sf-menu > li > a[title='Women']"));
            categoryHeader.Click();

            var productCounter = driver.FindElement(By.CssSelector(".heading-counter"));
            StringAssert.Contains("7", productCounter.Text);
        }


        [Test]
        public void IleSukienek()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");

            var categoryHeader = driver.FindElement(By.CssSelector("ul.sf-menu > li > a[title='Dresses']"));
            categoryHeader.Click();

            var productCounter = driver.FindElement(By.CssSelector(".heading-counter"));
            StringAssert.Contains("5", productCounter.Text);
        }


        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

    }
}
