using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;

//Launch a new Firefox browser.
//Open http://demoqa.com/frames-and-windows/
//Use this statement to click on a New Window button “driver.FindElement(By.XPath(“.//*[@id=’tabs-1′]/div/p/a”)).Click();”
//Close the browser using Close() command

namespace ToolsQA.Selenium_Basics
{
    class PracticalExercise2

    {
        IWebDriver driver;

        [SetUp]
        public void Initializing()
        {
            driver = new FirefoxDriver();
        }

        [Test]
        public void FindElementOnPage()
        {
            driver.Navigate().GoToUrl("http://demoqa.com/frames-and-windows/");
            IWebElement LinkToTab = driver.FindElement(By.XPath(".//div[@class='inside_contain']/p/a"));
            LinkToTab.Click();            
        }      

        [TearDown]
        public void EndTest()
        {
            driver.Close();
            /*You will notice that only one window will close.Next time use Quit() command instead of Close(). 
            At that time selenium will close both the windows.*/

           driver.Quit();
        }
    }
}
