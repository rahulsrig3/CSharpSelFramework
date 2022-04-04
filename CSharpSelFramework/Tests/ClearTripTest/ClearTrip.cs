using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpSelFramework.Tests.ClearTripTest
{
    internal class ClearTrip
    {
        [Test]
        public void clearTripAuto()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.cleartrip.com/flights");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            DateTime today = DateTime.Now;
            var tommorow = today.AddDays(1);
            String tommorowDate = tommorow.ToString("D");
            Console.WriteLine(tommorowDate);

            string[] dateInString = tommorowDate.Split(' ');
            int dom = Convert.ToInt16(dateInString[0]);
            string month = dateInString[1];
            string year = dateInString[2];
            Console.WriteLine(dom);

            //IWebElement fromLoc = driver.FindElement(By.XPath("//h4[text()='From']/parent::div/div/div/div/child::input[@placeholder='Any worldwide city or airport']"));
            IWebElement fromLoc = driver.FindElement(By.XPath("//h4[.='From']/parent::div/descendant::input[@placeholder='Any worldwide city or airport']"));
            fromLoc.SendKeys("Bangalore");
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//p[contains(text(),'Bangalore')]")).Click();

            //IWebElement toLoc = driver.FindElement(By.XPath("//h4[text()='To']/parent::div/div/div/div/input[@placeholder='Any worldwide city or airport']"));
            IWebElement toLoc = driver.FindElement(By.XPath("//h4[.='To']/parent::div/descendant::input[@placeholder='Any worldwide city or airport']"));
            toLoc.SendKeys("Mumbai");
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//p[contains(text(),'Mumbai')]")).Click();

            driver.FindElement(By.XPath("//h4[.='Depart on']/ancestor::div[@class='flex flex-middle mt-6 w-100p']/following-sibling::div/descendant::button")).Click();
            Thread.Sleep(2000);

            driver.FindElement(By.XPath("//div[contains(text(),'" + month + " " + year + "')]/ancestor::div[@class='DayPicker-Month']/descendant::div[text()='" + dom + "']")).Click();
            Thread.Sleep(2000);

            driver.FindElement(By.XPath("//h4[text()='Adults']/parent::div[@class='mb-4']/descendant::select")).SendKeys("5");
            //driver.FindElement(By.XPath("//h4[text()='Adults']/parent::div[@class='mb-4']/descendant::select")).Click();
            
            driver.FindElement(By.XPath("//button[text()='Search flights']")).Click();

            //h4[text()='From']/ancestor::div[@class='col flex flex-middle']/descendant::input[@class='field bw-1 bs-solid w-100p p-2 box-border br-4 fs-2 c-neutral-900 h-8 bc-neutral-100 c-neutral-900 focus:bc-secondary-500 flex flex-middle flex-between t-all fs-2 focus:bc-secondary-500 bg-transparent bc-neutral-100 pr-2 pl-3 pt-2 pb-2 ba br-4 h-8 null']
            //h4[text()='From']/parent::div/div/div/div/child::input[@placeholder="Any worldwide city or airport"]/parent::div/following-sibling::div/ul/div/following-sibling::li/p[text()='Bangalore, IN - Kempegowda International Airport (BLR)']

        }
    }
}
