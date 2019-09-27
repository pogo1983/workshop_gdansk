using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium
{
    [TestFixture]
    public class ContactUsTest:TestBase
    {
        [Test]
        public void SendFormWithoutData()

        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            var categoryHeader = driver.FindElement(By.CssSelector("#contact-link > a:nth-child(1)"));
            categoryHeader.Click();
            var contactSend = driver.FindElement(By.CssSelector("#submitMessage"));
            contactSend.Click();

            var checkError = driver.FindElement(By.CssSelector(".alert"));
            string text = checkError.Text;

            StringAssert.Contains("Invalid email address.", text);


            //driver = new ChromeDriver;
            //var driver = new ChromeDriver();//tworzenie obiektu drivera, konstruktor
            //Assert.AreEqual(2,1);// error zatrzymuje aplikacje
            // driver.Quit();//close zamknie okno a quit drivera
        }

    }
}
