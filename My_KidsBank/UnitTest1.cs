using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace My_KidsBank
{
    public class Tests
    {
       

        [Test]
        public void Test1()
        {
            IWebDriver driver =  new ChromeDriver();

            driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/register.htm");

            //By.ID
            driver.FindElement(By.Id("customer.firstName")).SendKeys("Jay");
            driver.FindElement(By.Id("customer.lastName")).SendKeys("ken");

            //By.name
            driver.FindElement(By.Name("customer.address.street")).SendKeys("12th Chruch Street , Down Town");
            driver.FindElement(By.Name("customer.address.city")).SendKeys("NewYork");

            //classname doesnt works
            //driver.FindElement(By.ClassName("customer.address.city")).SendKeys("NewYork");

            //By.CssSelector
            driver.FindElement(By.CssSelector("#customer\\.address\\.state")).SendKeys("Alabama");
            driver.FindElement(By.CssSelector("#customer\\.address\\.zipCode")).SendKeys("563531");

            //By.XPath *** Copy XPath
            driver.FindElement(By.XPath("//*[@id='customer.phoneNumber']")).SendKeys("0001112229");

            //By.Xpath ***Copy Full XPath
            driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[2]/form/table/tbody/tr[8]/td[2]/input")).SendKeys("2012344");

        }

    }
}