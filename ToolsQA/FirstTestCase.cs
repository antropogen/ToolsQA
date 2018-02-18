using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace ToolsQA
{
    class FirstTestCase
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            //driver.Url = "http://www.demoqa.com";
            driver.Navigate().GoToUrl("http://www.demoqa.com");
        }
    }
}
