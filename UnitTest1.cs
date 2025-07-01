using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumDemo
{
    public class Tests
    {
        [Test]
        public void LoginPageTitleTest()
        {
            using var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://example.com");
            Assert.That(driver.Title, Is.EqualTo("Example Domain"));
        }
    }
}
