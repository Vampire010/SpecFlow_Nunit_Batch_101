using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace My_KidsBank.Locaters
{
    public class Inspect_By_Id
    {
        [Test]
        public void Test1()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://parabank.parasoft.com");

            foreach (IWebElement item in driver.FindElements(By.TagName("a")))
            {
                Console.WriteLine(item.GetAttribute("href"));
            }

           

        }

    }
}
