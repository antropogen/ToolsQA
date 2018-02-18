using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace ToolsQA
{
    class NUnitTest
    {
        IWebDriver driver;

        [SetUp]
        public void Initialize()
        {
            driver = new FirefoxDriver();
        }

        [Test]
        public void OpenAppTest()
        {
            driver.Url = "http://www.demoqa.com";
        }

        [TearDown]
        public void CloseApp()
        {
            driver.Quit();
        }
            
        
    }
}
