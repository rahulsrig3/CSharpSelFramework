using ClosedXML.Excel;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpSelFramework.Tests.FlipkartTest
{
    internal class XpathForEclipse
    {
        [Test]
        public void clickOnElement()
        {
            DateTime today = DateTime.Now;  //11-03-2022 14:38:42 -> stores date and time in this format
            var tomorrow = today.AddDays(1);
            String tomorrowDate = tomorrow.ToString("D");
            Console.WriteLine(tomorrowDate);

            String[] dateInString = tomorrowDate.Split(' ');
            int dateOfMonth = Convert.ToInt16(dateInString[0]);
            string month = dateInString[1];
            string year = dateInString[2];

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.flipkart.com/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();

            driver.FindElement(By.XPath("//button[@class='_2KpZ6l _2doB4z']")).Click();
            Thread.Sleep(3000);

            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElement(By.XPath("//img[@alt='Electronics']"))).Perform();
            Thread.Sleep(5000);
            action.MoveToElement(driver.FindElement(By.XPath("//a[text()='Gaming']"))).Build().Perform();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//a[text()='Gaming Keyboards']")).Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            By loc = By.XPath(@"//a[text()='Flipkart SmartBuy PK-72 LED Backlit with Mechanical Swi...']");
            wait.Until(ExpectedConditions.ElementIsVisible(loc)).Click();




            ////program to read data 
            //var workbook = new XLWorkbook(@"E:\Test Yanta\C# Files\CSharpSelFramework\CSharpSelFramework\TestData\workBook.xlsx");
            //var worksheet = workbook.Worksheet(1);
            //var values = worksheet.Cell(1, 2).Value;
            //string? value = values.ToString();
            //Console.WriteLine(value);
        }
        
    }
}
