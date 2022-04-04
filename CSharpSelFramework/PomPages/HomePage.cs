using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpSelFramework.PomPages
{
    public class HomePage
    {
        IWebDriver driver ;
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement organizationButton => driver.FindElement(By.LinkText("Organizations"));
        private IWebElement logoutButton => driver.FindElement(By.XPath("//img[@src='themes/softed/images/user.PNG']"));
        private IWebElement signOutLink => driver.FindElement(By.LinkText("Sign Out"));

        public IWebElement getOrganizationButton()
        {
            return organizationButton;
        }
        public IWebElement getLogoutButton()
        {
            return logoutButton;
        }
        public IWebElement getSignOutLink()
        {
            return signOutLink;
        }
        public void VTigerHome()
        {
            organizationButton.Click();
        }
        public void VTigerLogout(IWebDriver driver)
        {
            Actions action = new Actions(driver);
            action.MoveToElement(logoutButton).Build().Perform();
            Thread.Sleep(3000);
            signOutLink.Click();
        }
    }
}
