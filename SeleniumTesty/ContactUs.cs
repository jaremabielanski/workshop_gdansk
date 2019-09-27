using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace SeleniumTesty
{
    [TestFixture]
    public class ContactUs : TestBase
    {

        ContactUsPage sut;

        [SetUp]
        public void ContactUsSetup()
        {
            sut = new ContactUsPage(driver);
            sut.GoToPage();
        }


        [Test]
        public void CatchError()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");

            // clicks Contact Us
            sut.ClickContactButton();

            // clicks Send
            sut.ClickSendButton();

            // check for error message
            sut.WebDriverWaitForError();
     
            Thread.Sleep(3000);
        }
    }
}
