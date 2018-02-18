using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;

//Launch a new Firefox browser.
//Open Store.DemoQA.com
//Get Page Title name and Title length
//Print Page Title and Title length on the Console.
//Get Page URL and Page Url Length
//Print Page URL and Page Url Length on the Console.
//Get Page Source (HTML Source code) and Page Source length
//Print Page Length on Console.
//Close the Browser.
namespace ToolsQA.Selenium_Basics
{
    class PracticalExercise1
    {
        IWebDriver driver;

        [SetUp]
        public void Initializing()
        {
            driver = new FirefoxDriver();
        }

        [Test]
        public void PrintingToConsole()
        {
            driver.Navigate().GoToUrl("http://Store.DemoQA.com");
            String Title = driver.Title;
            int Length = Title.Length;
            Console.WriteLine("Title of the page is : " + Title);
            Console.WriteLine("Length of the title is: " + Length);

            String PageURL = driver.Url;
            int LengthURL = PageURL.Length;
            Console.WriteLine("URL of the page is : " + PageURL);
            Console.WriteLine("Length of the URL is: " + LengthURL);

            String PageSource = driver.PageSource;
            int PageSourceLength = driver.PageSource.Length;
            //Console.WriteLine("Page Source of the page is : " + PageSource);
            Console.WriteLine("Length of the Page Source is : " + PageSourceLength);
        }

        [TearDown]
        public void EndTest()
        {
            driver.Quit();
        }
    }
}
