using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Safari;


namespace ProjectWorkBenchInt
{
    [TestFixture]
    class Program
    {
        //init driver
        IWebDriver driver;

        [SetUp]
        public void LoginToTurnup()
        {
            //init and define webdriver
            driver = new SafariDriver();

            // navigate to browser and enter url
            driver.Navigate().GoToUrl("https://web.workbench.co.nz/WorkbenchTestV4/Workbench.aspx#/PurchaseRequisitions/DetailMobi.aspx/Create");

            //maximize screen
            driver.Manage().Window.Maximize();

            //created login page object
            LoginClass LoginObj = new LoginClass();
            LoginObj.Loginsteps(driver);
        }

        [Test]
        public void CreateReqPage()
        {

            //created object for create requisition page

            RequisitionPage createobj = new RequisitionPage();
            createobj.CreateRequisitionPage(driver);
        }

        [Test]
        public void AssignReqPage()
        {

            assignclass assignobj = new assignclass();
            assignobj.createassignfeature(driver);
        }

        [TearDown]
        public void TestClosure()
        {
            //close instances of open safari browser
            driver.Quit();

        }
    }
}
