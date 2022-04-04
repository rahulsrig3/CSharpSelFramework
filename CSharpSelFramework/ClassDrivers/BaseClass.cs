using CSharpSelFramework.Generics;
using CSharpSelFramework.PomPages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharpSelFramework.ClassDrivers
{
    public class BaseClass
    {
        public IWebDriver driver;

        public FileUtility fLib = new FileUtility();
        public ExcelUtility eLib = new ExcelUtility();
        public WebDriverUtility wLib = new WebDriverUtility();
        public CSharpUtility cLib = new CSharpUtility();

        [OneTimeSetUp]
        public void ConfigOneTimeSetUp()
        {
            string BROWSER = fLib.ReadDataFromRunSettings("browser");
            string URL = fLib.ReadDataFromRunSettings("url");


            if (BROWSER.Equals("chrome"))
            {
                driver = new ChromeDriver();
            }
            else if (BROWSER.Equals("firefox"))
            {
                driver = new FirefoxDriver();
            }
            else
            {
                Console.WriteLine("INVALID INPUT");
            }

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl(URL);
        }

        [SetUp]
        public void ConfigSetUp()
        {
            String USERNAME = fLib.ReadDataFromRunSettings("username");
            String PASSWORD = fLib.ReadDataFromRunSettings("password");

            LoginPage login = new LoginPage(driver);
            login.VTigerLogin(USERNAME, PASSWORD);
        }

        [TearDown]
        public void ConfigTearDown()
        {
            HomePage home = new HomePage(driver);
            home.VTigerLogout(driver);
        }

        [OneTimeTearDown]
        public void ConfigOneTimeTearDown()
        {
            driver.Quit();
        }
    }
}
