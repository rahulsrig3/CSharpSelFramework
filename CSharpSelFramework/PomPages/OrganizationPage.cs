using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSelFramework.PomPages
{
    public class OrganizationPage
    {
        IWebDriver driver = null;
        public OrganizationPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        private IWebElement organizationLink => driver.FindElement(By.XPath("//img[@title='Create Organization...']"));

        public IWebElement getOrganizationLink()
        {
            return organizationLink;
        }

        public void VTigerOrganization()
        {
            organizationLink.Click();
        }
    }
}
