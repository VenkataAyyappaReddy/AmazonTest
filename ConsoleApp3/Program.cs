using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using OpenQA.Selenium.Support.UI;
using System.Text;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.google.com/";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);// implicit wait
            driver.FindElement(By.Name("q")).SendKeys("facebook login");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
            // WebDriverWait wait = new WebDriverWait(driver,TimeSpan.FromSeconds(100));//explicit wait
            driver.FindElement(By.Name("btnK")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
            driver.FindElement(By.XPath("//*[@id='rso']/div[1]/div/div/table/tbody/tr[1]/td[1]/div/span/h3/a")).Click();
            driver.FindElement(By.Name("email")).SendKeys("g.v.ayyappareddy@gmail.com");
            driver.FindElement(By.Name("pass")).SendKeys("Reddy@12345");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1000);
            driver.FindElement(By.Name("login")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1000);
            driver.FindElement(By.ClassName("3ixn")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1000);

        }
    }
}
