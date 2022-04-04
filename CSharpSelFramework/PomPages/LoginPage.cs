using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSelFramework.PomPages
{
    public class LoginPage
    {
        IWebDriver driver = null;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement usernameTextField => driver.FindElement(By.XPath("//input[@name='user_name']"));
        private IWebElement passWordTextField => driver.FindElement(By.XPath("//input[@name='user_password']"));
        private IWebElement loginButton => driver.FindElement(By.XPath("//input[@id='submitButton']"));

        public IWebElement getUserNameTextField()
        {
            return usernameTextField;
        }   
        public IWebElement getPassWordTextField()
        {
            return passWordTextField;
        }
        public IWebElement getLoginButton()
        {
            return loginButton;
        }

        public void VTigerLogin(string username, string password)
        {
            //MaximizeWindow(driver);
            usernameTextField.SendKeys(username);
            passWordTextField.SendKeys(password);
            loginButton.Click();
        }
    }
}
