using System;
using System.Collections.Generic;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace YahooScrape1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver
            {
                Url = "https://finance.yahoo.com/portfolios"
            };

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            // Click login button
            driver.FindElement(By.XPath("//*[@id='uh']/header/section/div/a")).Click();

            // Submit login information
            driver.FindElement(By.Id("login-username")).SendKeys("chrismilkaitis.student@careerdevs.com" + Keys.Enter);
            driver.FindElement(By.Id("login-passwd")).SendKeys("projecttest@333" + Keys.Enter);

            // Close pop-up asking to link financial advisor info
            driver.FindElement(By.XPath("//*[@id='__dialog']/section/button")).Click();

            // Select portfolio profile
            driver.FindElement(By.XPath("//*[@id='main']/section/section/div/table/tbody/tr/td/a")).Click();

            // Access table data: Stock Names and send to List
            IList<IWebElement> stockNames = driver.FindElements(By.XPath("//td[@class='_1_2Qy']"));
            IList<IWebElement> stockPrice = stockPrice = driver.FindElements(By.XPath($"//tr[@data-index='0']//td[2]"));

            IList<IWebElement> stockInfo = driver.FindElements(By.XPath("//div[@class='gIc8M']/table/tbody/tr/td/span"));

            // Print number of stocks
            Console.WriteLine($"Total Stocks: {stockNames.Count}");
            Console.WriteLine($"Total Prices: {stockPrice.Count}");
            Console.WriteLine($"Items in Info: {stockInfo.Count}");

            //Print all stock names
            //for (int i = 0; i < stockNames.Count; i++)
            //{
            //    Console.WriteLine($"{stockNames[i].Text}");
            //}

            //for (int i = 0; i < stockNames.Count; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        Console.WriteLine("");
            //    }
            //    Console.WriteLine($"{stockNames[i].Text}: {stockPrice[i].Text}");
            //}
        }
    }
}
