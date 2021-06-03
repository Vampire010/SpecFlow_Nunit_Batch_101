using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace My_KidsBank_SpecFlow.Step_Def
{
    [Binding]
    public class Login_Step_Def
    {
        String test_url = "http://mykidsbank.org";

        IWebDriver driver;
        [Given(@"that I am on the Parbank_Site")]
        public void GivenUserShouldBeOnKidsbankLoginPage()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(test_url);

        }

        [Then(@"Enter Banker_ID")]
        public void ThenEnterBanker_ID()
        {
            driver.FindElement(By.XPath("/html/body/table/tbody/tr[1]/td/table/tbody/tr/td[2]/form/table/tbody/tr[2]/td[2]/span/input")).SendKeys("123456");
        }

        [Then(@"Enter UserName")]
        public void ThenEnterUserName()
        {
            driver.FindElement(By.XPath("/html/body/table/tbody/tr[1]/td/table/tbody/tr/td[2]/form/table/tbody/tr[2]/td[4]/span/input")).SendKeys("girish010");
        }

        [Then(@"Enter the Usr_Password")]
        public void ThenEnterTheUsr_Password()
        {
            driver.FindElement(By.XPath("/html/body/table/tbody/tr[1]/td/table/tbody/tr/td[2]/form/table/tbody/tr[2]/td[6]/span/input")).SendKeys("pass010");
        }

        [Then(@"Click Login_Button")]
        public void ThenClickLogin_Button()
        {
            driver.FindElement(By.XPath("//*[@id='clicked_when_enter_id']")).Click();
        }
    }
}
