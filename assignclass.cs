using System;
using System.Threading;
using OpenQA.Selenium;
namespace ProjectWorkBenchInt
{
    public class assignclass
    {
        public void createassignfeature(IWebDriver driver)
        {
            //user can identify and search the editor to assign
            IWebElement searcheditor = driver.FindElement(By.XPath("//*[@id='AssignDialog_Editor']"));
            searcheditor.SendKeys("maloney");
            Thread.Sleep(500);


            //identify and select the editor
            IWebElement editor = driver.FindElement(By.XPath("//*[@id='ui-id-9']/a/span[1]"));
            editor.Click();
            Thread.Sleep(500);

            

            //identify and click on assigm button
            IWebElement assign = driver.FindElement(By.XPath("//*[@id='viewSelectLink_AssignDialog_Editor_dialogDiv_PersonList_Select_0']"));
            assign.Click();
            Thread.Sleep(500);
        }
    }
}
