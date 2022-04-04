using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpSelFramework.PomPages;
using System.Threading;
using CSharpSelFramework.ClassDrivers;

namespace CSharpSelFramework.Tests.OrganizationTest
{
    [TestFixture]
    public class CreateOrganization : BaseClass
    {
        [Test]
        [CategoryAttribute("SmokeTesting")]
        public void createNewOrganization()
        {
            string organizationName = eLib.ReadDataFromExcel("Organization", 1, 2) + cLib.GenerateRandomNum();

            HomePage home = new HomePage(driver);
            home.VTigerHome();

            OrganizationPage organization = new OrganizationPage(driver);
            organization.VTigerOrganization();

            CreatingNewOrganizationPage createNewOrganization = new CreatingNewOrganizationPage(driver);
            createNewOrganization.VTigerCreateNewOrganization(organizationName);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //CreatingNewOrganizationPage createNewOrganizationWithInd = new CreatingNewOrganizationPage(driver);
            //createNewOrganizationWithInd.VTigerCreateNewOrganizationWithInd(organizationName, industyName);
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            OrganizationInformationPage organizationInformation = new OrganizationInformationPage(driver);
            string succMsg = organizationInformation.getSuccOrgCreationMsg().Text;

            if (succMsg.Contains(organizationName))
            {
                //Console.WriteLine("organization created successfully ==> Passed Test Script");
                Assert.True(true, "organization created successfully ==> Passed Test Script");
            }
            else
            {
                //Console.WriteLine("organization not created successfully ==> Failed Test Script");
                Assert.Fail("organization not created successfully ==> Failed Test Script");
            }

        }

        [Test]
        [CategoryAttribute("RegressionTesting")]
        public void regressiontestingsis()
        {
            string organizationName = eLib.ReadDataFromExcel("Organization", 1, 2) + cLib.GenerateRandomNum();
            string industyName = eLib.ReadDataFromExcel("Organization", 2, 2);

            HomePage home = new HomePage(driver);
            home.VTigerHome();

            OrganizationPage organization = new OrganizationPage(driver);
            organization.VTigerOrganization();

            CreatingNewOrganizationPage createNewOrganizationWithInd = new CreatingNewOrganizationPage(driver);
            createNewOrganizationWithInd.VTigerCreateNewOrganizationWithInd(organizationName, industyName);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            OrganizationInformationPage organizationInformation = new OrganizationInformationPage(driver);
            string succMsg = organizationInformation.getSuccOrgCreationMsg().Text;

            if (succMsg.Contains(organizationName))
            {
                //Console.WriteLine("organization created successfully ==> Passed Test Script");
                Assert.True(true, "organization created successfully ==> Passed Test Script");
            }
            else
            {
                //Console.WriteLine("organization not created successfully ==> Failed Test Script");
                Assert.Fail("organization not created successfully ==> Failed Test Script");
            }
        }
    }
}
