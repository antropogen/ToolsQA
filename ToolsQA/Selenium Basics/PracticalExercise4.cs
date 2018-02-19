
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ToolsQA.Selenium_Basics
{
    class PracticalExercise4
    {
        IWebDriver driver;

        [SetUp]
        public void Initializing()
        {
            driver = new FirefoxDriver();            
        }

        [Test]
        //Launch new Browser
        //Open “http://toolsqa.wpengine.com/automation-practice-form/“
        //Challenge One – Select the deselected Radio button(female) for category Sex(Use Selected method)
        //Challenge Two – Select the Third radio button for category ‘Years of Exp’ (Use Id attribute to select Radio button)
        //Challenge Three – Check the Check Box ‘Automation Tester’ for category ‘Profession'( Use Value attribute to match the selection)
        //Challenge Four – Check the Check Box ‘Selenium IDE’ for category ‘Automation Tool’ (Use CssSelector)

        public void RadioButtonsOperations()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            // Launch the URL
            driver.Url = "http://toolsqa.wpengine.com/automation-practice-form";

            // Step 3 : Select the deselected Radio button (female) for category Sex (Use IsSelected method)
            // Storing all the elements under category 'Sex' in the list of WebLements	
            IList<IWebElement> rdBtn_Sex = driver.FindElements(By.Name("sex"));

            // Create a boolean variable which will hold the value (True/False)
            Boolean bValue = true;

            // This statement will return True, in case of first Radio button is selected
            bValue = rdBtn_Sex.ElementAt(0).Selected;

            // This will check that if the bValue is True means if the first radio button is selected
            if (bValue == false)
            {
                // This will select Second radio button, if the first radio button is selected by default
                rdBtn_Sex.ElementAt(1).Click();
            }
            else
            {
                // If the first radio button is not selected by default, the first will be selected
                rdBtn_Sex.ElementAt(0).Click();
            }


        }

        [TearDown]
        public void EndTest()
        {
            driver.Quit();
        }
    }
}
