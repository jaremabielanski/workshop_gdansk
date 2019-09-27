using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTesty
{
    [TestFixture]
    public class Categories : TestBase
    {

        CategoriesPage sut;

        [SetUp]
        public void CategoriesSetup()
        {
            sut = new CategoriesPage(driver);
            sut.GoToPage();
        }

        [Test]
        public void TShirts()
        {
            sut.GoToPage();
            sut.ClickBtn();

            StringAssert.Contains(sut.CountObjectsOnPage('w'), sut.CountObjectsOnPage('p'));
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

    }
}
