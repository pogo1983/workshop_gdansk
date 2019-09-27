using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;


namespace Selenium
{
    [TestFixture]
    public class UnitTest1
    {
        IWebDriver driver;


        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void FirstTest()
            
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            //driver = new ChromeDriver;
            //var driver = new ChromeDriver();//tworzenie obiektu drivera, konstruktor
           //Assert.AreEqual(2,1);// error zatrzymuje aplikacje
           // driver.Quit();//close zamknie okno a quit drivera
        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
