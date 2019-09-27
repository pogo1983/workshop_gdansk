using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Selenium
{
   [TestFixture]
    public class TestBase
    {
       protected IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            var waitTime = new System.TimeSpan(0, 0, 7);
            driver.Manage().Timeouts().ImplicitWait = waitTime;
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
