﻿using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.google.com/";
            
        }
    }
}
