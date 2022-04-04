using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSelFramework.PomPages
{
    public class OrganizationInformationPage
    {
        IWebDriver driver = null;       
        public OrganizationInformationPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        private IWebElement succOrgCreationMsg => driver.FindElement(By.XPath("//span[@class='dvHeaderText']"));
        public IWebElement getSuccOrgCreationMsg()
        {
            return succOrgCreationMsg;
        }

    }
}
