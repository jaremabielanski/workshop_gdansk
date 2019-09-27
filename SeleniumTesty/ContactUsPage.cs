using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTesty
{
    public class ContactUsPage
    {

        private IWebDriver driver;
        private WebDriverWait wait;

        private By sendButtonLocator = By.CssSelector("div.submit>button>span");
        private By contactButtonLocator = By.CssSelector("div#contact-link > a");
        private By errMsgLocator = By.CssSelector("div.alert > p");

        public ContactUsPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void GoToPage()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=contact");
        }

        public void ClickContactButton()
        {
            driver.FindElement(contactButtonLocator).Click();
        }

        public void ClickSendButton()
        {
            driver.FindElement(sendButtonLocator).Click();
        }
        public void WebDriverWaitForError()
        {
            var waitTime = new System.TimeSpan(0, 0, 1);
            
            wait = new WebDriverWait(driver, waitTime);
            IWebElement elWait = wait.Until(ExpectedConditions.ElementExists(errMsgLocator));
            StringAssert.Contains("1 error", elWait.Text.ToString());
        }

    }
}
