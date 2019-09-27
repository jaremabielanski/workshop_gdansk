using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTesty
{
    public class CategoriesPage
    {

        private IWebDriver driver;
        private WebDriverWait wait;
        //private By sukienkiButtonLocator = By.CssSelector("");
        //private By kobietyButtonLocator = By.CssSelector("");
        private By tshirtsButtonLocator = By.CssSelector("ul.sf-menu > li > a[title='T-shirts']");
        private By productCounterLocator = By.CssSelector(".heading -counter");
        private By webElementsLocator = By.CssSelector("div.product-container");
        

        public CategoriesPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void GoToPage()
        {
            string url = ConfigurationManager.AppSettings["url"];
            driver.Navigate().GoToUrl(url);
        }

        public void ClickBtn()
        {
            driver.FindElement(tshirtsButtonLocator).Click();
        }

        public string CountObjectsOnPage(char c)
        {

            switch(c)
            {
                case 'p':
                        {
                        var productCounter = driver.FindElement(productCounterLocator);
                        return productCounter.ToString();
                        }
                case 'w':
                        {
                        var webElements = driver.FindElements(webElementsLocator);
                        return webElements.Count.ToString();
                        }
            }

            return String.Empty;
        }
    }
}

