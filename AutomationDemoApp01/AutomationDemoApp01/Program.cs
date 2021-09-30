using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationDemoApp01
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver(@"D:\");
            string url = "http://www.google.com";
            driver.Navigate().GoToUrl(url);
            Thread.Sleep(2000);

            IWebElement element1 = driver.FindElement(By.Name("q"));
            Thread.Sleep(2000);
            element1.SendKeys("Near by Malls" + Keys.Enter);


            Thread.Sleep(10000);
            driver.Quit();

        }
    }
}
