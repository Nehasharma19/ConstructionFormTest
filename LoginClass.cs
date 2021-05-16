using System;
using System.Threading;
using OpenQA.Selenium;

namespace ProjectWorkBenchInt
{
    public class LoginClass
    {
        public void Loginsteps(IWebDriver driver)
        {
            //Identify and enter username
            IWebElement username = driver.FindElement(By.XPath("//*[@id='userName']"));
            username.SendKeys("demo1");

            //Identify and enter password
            IWebElement password = driver.FindElement(By.XPath("//*[@id='userPassword']"));
            password.SendKeys("test");

            //Identify and click login button
            IWebElement Login = driver.FindElement(By.XPath("//*[@id='loginButton']/span"));
            Login.Click();

            Thread.Sleep(2000);

            //validate if user is able to login sucessfully
            IWebElement dashboard = driver.FindElement(By.XPath("//*[@id='breadcrumbs']/ul/li[1]/a"));
            if (dashboard.Text == "Dashboard")
            {
                Console.WriteLine("Login Test Pass");
            }
            else
            {
                Console.WriteLine("Login test failed");
            }


        }
    }
}
