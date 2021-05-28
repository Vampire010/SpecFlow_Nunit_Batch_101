using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace My_KidsBank.Locaters
{
    public class XPATH_Contains
    {
        [Test]
        public void test1()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/register.htm");

            driver.FindElement(By.XPath("//*[@id='customer.firstNames' or @name='customer.firstName']")).SendKeys("Devil121");
            driver.FindElement(By.XPath("//*[@id='customer.lastNames' and @name='customer.lastName']")).SendKeys("DVampire");

        }
    }
}
