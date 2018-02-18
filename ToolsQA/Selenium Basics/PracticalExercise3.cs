using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;

//Launch new Browser
//Open DemoQA.com website
//Click on Registration link using “driver.findElement(By.xpath(“.//*[@id=’menu-item-374′]/a”)).click();“
//Come back to Home page(Use ‘Back’ command)
//Again go back to Registration page(This time use ‘Forward’ command)
//Again come back to Home page(This time use ‘To’ command)
//Refresh the Browser(Use ‘Refresh’ command)
//Close the Browser

namespace ToolsQA.Selenium_Basics
{
    class PracticalExercise3

    {
        IWebDriver driver;

        [SetUp]
        public void Initializing()
        {
            driver = new FirefoxDriver();
        }

        [Test]
        public void NavigationInBrowser()
        {
            driver.Navigate().GoToUrl("http://DemoQA.com");
            IWebElement RegistrationLink = driver.FindElement(By.XPath(" .//*[@id='menu-item-374']/a"));
            //".//a[@class and text()='Registration']"
           

            RegistrationLink.Click();
            driver.Navigate().Back();
            driver.Navigate().Forward();
            driver.Navigate().Refresh();
            String TitleText = driver.Title;
            Console.WriteLine("The Title of the window is : " + TitleText);
            
        }

        [Test]
        //Launch new Browser
        //Open URL http://toolsqa.wpengine.com/automation-practice-form/
        //Type Name & Last Name(Use Name locator)
        //Click on Submit button(Use ID locator)
        public void WebElementLocators()
        {
            driver.Navigate().GoToUrl("http://toolsqa.wpengine.com/automation-practice-form/");
            //// Type Name in the FirstName text box      
            //driver.FindElement(By.Name("firstname")).SendKeys("Lakshay");

            ////Type LastName in the LastName text box
            //driver.FindElement(By.Name("lastname")).SendKeys("Sharma");

            //// Click on the Submit button
            //driver.FindElement(By.Id("submit")).Click();

            IWebElement Name = driver.FindElement(By.Name("firstname"));
            Name.SendKeys("Oleksandr");

            IWebElement LastName = driver.FindElement(By.Name("lastname"));
            LastName.SendKeys("Shevchuk");

            IWebElement SubmitButton = driver.FindElement(By.Id("submit"));
            SubmitButton.Submit();

        }

        [TearDown]
        public void EndTest()
        {
            driver.Quit();           
        }
    }
}
