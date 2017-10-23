using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace WebDriver_Lab
{
    [TestFixture]
    public class WebDTests
    {
        [Test]
        public void openGoogle()
        {
            IWebDriver firefox = new FirefoxDriver();
            firefox.Navigate().GoToUrl("http://www.github.com");

            IWebElement buttonSearch = firefox.FindElement(By.XPath("//a[@class='text-bold text-white no-underline']"));
            buttonSearch.Click();


            IWebElement loginWrite = firefox.FindElement(By.Id("login_field"));
            loginWrite.SendKeys("testautomationuser");

            IWebElement passWrite = firefox.FindElement(By.Id("password"));
            passWrite.SendKeys("Time4Death!");

            IWebElement loginClick = firefox.FindElement(By.Name("commit"));
            loginClick.Click();

        }

    }
}
