using System;
using System.Threading;
using OpenQA.Selenium;
namespace ProjectWorkBenchInt
{
    public class RequisitionPage
    {
        public void CreateRequisitionPage(IWebDriver driver)
        {
            Thread.Sleep(1000);
            //identify and input the job search
            IWebElement search = driver.FindElement(By.XPath("//*[@id='purchaseRequisitionEntry_Form']/div[2]/div[1]/div/span/i"));
            search.Click();

            Thread.Sleep(1000);

            //identify and click filter button 
            IWebElement filter = driver.FindElement(By.XPath("//*[@id='dynamicPredicateGeneralFields_Job_dialogDiv_JobList']/dynamic-predicate-rows[2]/div/fieldset/span[1]/span[1]"));
            filter.Click();
            Thread.Sleep(500);

            //identify and select jobCode button
            IWebElement jobcode = driver.FindElement(By.XPath("//*[@id='GeneralFields_Job_dialogDiv_JobList_predicate_PredicateRows_0__LeftOperand']"));
            jobcode.Click();

            //identify and selects"equalto"
            IWebElement equalto = driver.FindElement(By.XPath("//*[@id='GeneralFields_Job_dialogDiv_JobList_predicate_PredicateRows_0__Operator']"));
            equalto.Click();

            //identify and input jobcode value
            IWebElement value = driver.FindElement(By.XPath("//*[@id='GeneralFields_Job_dialogDiv_JobList_predicate_PredicateRows_0__RightOperand_0_']"));
            value.SendKeys("4112");
            Thread.Sleep(500);

            

            //identify and click apply filter button
            IWebElement applyfilter = driver.FindElement(By.XPath("//*[@id='btnApply_predicate']"));
            applyfilter.Click();

            Thread.Sleep(1000);

            //identify and select the 4112 jobcode
            IWebElement Jobcode = driver.FindElement(By.XPath("//*[@id='viewSelectLink_GeneralFields_Job_dialogDiv_JobList_Select_0']"));
            Jobcode.Click();
            Thread.Sleep(1000);

            //Identify description and input description
            IWebElement description = driver.FindElement(By.XPath("//*[@id='GeneralFields_Description']"));
            description.SendKeys("Here is the description");

            //Identify and search for requested person
            IWebElement person = driver.FindElement(By.XPath("//*[@id='purchaseRequisitionEntry_Form']/div[2]/div[3]/div/span"));
            person.Click();
            Thread.Sleep(500);

            // identify and click full name
            IWebElement fullname = driver.FindElement(By.XPath("//*[@id='GeneralFields_RequestedFor_dialogDiv_PersonLookupGrid_predicate_PredicateRows_0__LeftOperand']"));
            fullname.Click();

            //identify and starts with
            IWebElement startwith = driver.FindElement(By.XPath("//*[@id='GeneralFields_RequestedFor_dialogDiv_PersonLookupGrid_predicate_PredicateRows_0__Operator']"));
            startwith.Click();
            Thread.Sleep(500);

            //identify and write name
            IWebElement name = driver.FindElement(By.XPath("//*[@id='GeneralFields_RequestedFor_dialogDiv_PersonLookupGrid_predicate_PredicateRows_0__RightOperand_0_']"));
            name.SendKeys("Malcolm Mackay");
            Thread.Sleep(500);

            //identify and click on apply filter
            IWebElement apply = driver.FindElement(By.XPath("//*[@id='btnApply_predicate']"));
            apply.Click();
            Thread.Sleep(500);

            //identify and select malcolmmackay
            IWebElement malcolmmackay = driver.FindElement(By.XPath("//*[@id='viewSelectLink_GeneralFields_RequestedFor_dialogDiv_PersonLookupGrid_Code_0']"));
            malcolmmackay.Click();



            //identify and select delievery date
            IWebElement delieverydate = driver.FindElement(By.XPath("//*[@id='AddressesFields_RequiredDate']"));
            delieverydate.SendKeys("18-May-2021");
            Thread.Sleep(500);





            //identify and click on search
            IWebElement activity = driver.FindElement(By.XPath("//*[@id='purchaseRequisitionEntry_Form']/div[3]/div[2]/div/span/i"));
            activity.Click();
            Thread.Sleep(1000);

            //identify and select activity code



            //identify and input the activity code value
            //IWebElement activitycode = driver.FindElement(By.XPath("//*[@id='itemActivity_dialogDiv_ActivityLookupGrid_predicate_PredicateRows_0__RightOperand_0_']"));
            //activitycode.SendKeys("ACCOM");
            //Thread.Sleep(1000);

            //identify and select ACCOM
            IWebElement accom = driver.FindElement(By.XPath("//*[@id='viewSelectLink_itemActivity_dialogDiv_ActivityLookupGrid_Code_0']"));
            accom.Click();
            Thread.Sleep(500);


            //identify and input line description
            IWebElement linedescription = driver.FindElement(By.XPath("//*[@id='itemDescription']"));
            linedescription.SendKeys("Here is specifies the description of line");
            Thread.Sleep(500);

            //identify and input quantity
            IWebElement quantity = driver.FindElement(By.XPath("//*[@id='itemQuantity']"));
            quantity.SendKeys("2");
            Thread.Sleep(500);

            //identify and input unit cost
            IWebElement cost = driver.FindElement(By.XPath("//*[@id='itemUnitCost']"));
            cost.SendKeys("100");
            Thread.Sleep(500);

            //identify and click save button
            IWebElement saveitem = driver.FindElement(By.XPath("//*[@id='purchaseRequisitionEntry_Form']/div[3]/div[6]/div[2]/div/button/span[1]"));
            saveitem.Click();
            Thread.Sleep(500);

            //identify and click submit button
            IWebElement submit = driver.FindElement(By.XPath("//*[@id='purchaseRequisitionEntry_Form']/div[7]/div[2]/div/button/span[1]"));
            submit.Click();
            Thread.Sleep(500);



        }




    }
}
