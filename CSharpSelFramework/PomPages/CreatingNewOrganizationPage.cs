using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSelFramework.PomPages
{
    public class CreatingNewOrganizationPage
    {
        IWebDriver driver = null;
        public CreatingNewOrganizationPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        private IWebElement organizationNameTextField => driver.FindElement(By.XPath("//input[@name='accountname']"));
        private IWebElement industryDropBox => driver.FindElement(By.XPath("//select[@name='industry']"));
        private IWebElement saveButton => driver.FindElement(By.XPath("//input[@title='Save [Alt+S]']"));
        public IWebElement getOrganizationNameTextField()
        {
            return organizationNameTextField;
        }
        public IWebElement getIndustryDropBox()
        {
            return industryDropBox;
        }
        public IWebElement getSaveButton()
        {
            return saveButton;
        }

        public void VTigerCreateNewOrganization(string organizationName)
        {
            Random random = new Random();
            organizationNameTextField.SendKeys(organizationName+random.Next(1000));
            saveButton.Click();
        }
        public void VTigerCreateNewOrganizationWithInd(String organizationName,string text)
        {
            Random random = new Random();
            //random.Next(1000);
            organizationNameTextField.SendKeys(organizationName+random.Next(1000));
            SelectElement element = new SelectElement(industryDropBox);
            element.SelectByValue(text);
            saveButton.Click();
        }
    }
}
