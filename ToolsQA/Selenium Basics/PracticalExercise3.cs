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
        //Practice Exercise 1
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

        [Test]
        //Practice Exercise 2
        //Launch new Browser
        //Open URL http://toolsqa.wpengine.com/automation-practice-form/
        //Click on the Link “Partial Link Test” (Use ‘PatialLinkTest’ locator and search by ‘Partial’ word)
        //Identify Submit button with ‘TagName’, convert it in to string and print it on the console
        //Click on the Link “Link Test” (Use ‘LinkTest’ locator)

        public void WebElementByPartialLink()
        {
            driver.Navigate().GoToUrl("http://toolsqa.wpengine.com/automation-practice-form/");
            IWebElement PartialLink = driver.FindElement(By.PartialLinkText("Partial"));
            PartialLink.Click();
            Console.WriteLine(">>> Partical Link Test Pass");

            IWebElement SubmitButton = driver.FindElement(By.TagName("button"));
            String NameOfButton = SubmitButton.ToString();
            Console.WriteLine("\n>>> The Submit Button is following : " + NameOfButton);
            IWebElement LinkTest = driver.FindElement(By.LinkText("Link Test"));
            LinkTest.Click();
            Console.WriteLine("\n>>> Link Test Pass");

        }           

        [TearDown]
        public void EndTest()
        {
            driver.Quit();           
        }
    }
}
