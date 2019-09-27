using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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

            WebDriverWait waitDriver = new WebDriverWait(driver, new System.TimeSpan(0, 0, 15));
            var checkError = waitDriver.Until(ExpectedConditions.ElementExists(By.CssSelector(".alert")));

            //var checkError = driver.FindElement(By.CssSelector(".alert"));
            string text = checkError.Text;

            StringAssert.Contains("Invalid email address.", text);
           // Assert.That(checkError.Text, Is.EqualTo("Invalid email address."));//tego sie uzywa bo wygodniejsze

            //driver = new ChromeDriver;
            //var driver = new ChromeDriver();//tworzenie obiektu drivera, konstruktor
            //Assert.AreEqual(2,1);// error zatrzymuje aplikacje
            // driver.Quit();//close zamknie okno a quit drivera
        }

    }
}
