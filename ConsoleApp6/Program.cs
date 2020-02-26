using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.google.com";
          //  driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(1);
            driver.FindElement(By.Name("q")).SendKeys("Amazon online shopping");
            driver.Manage().Timeouts().ImplicitWait  = TimeSpan.FromSeconds(60);
            driver.FindElement(By.ClassName ("gNO89b")).Click();
          //  driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            driver.FindElement(By.ClassName("sA5rQ")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
            driver.FindElement(By.Id("nav-hamburger-menu")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
            driver.FindElement(By.Id("hmenu-customer-name")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
            driver.FindElement(By.Name("email")).SendKeys("g.v.ayyappareddy@gmail.com");
            driver.FindElement(By.Id("continue")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
            driver.FindElement(By.Name("password")).SendKeys("reddy12345");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100); 
            driver.FindElement(By.Id("signInSubmit")).Click();
            driver.FindElement(By.Name("field-keywords")).SendKeys("Advance C# book ");





        }
    }
}
