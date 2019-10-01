using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace Selenium
{
    [TestFixture]
    public class CategoriesTest:TestBase
    {
       //IWebDriver driver;


        //[SetUp]
        //public void Setup()
        //{
        //    driver = new ChromeDriver();
        //    var waitTime = new System.TimeSpan(0,0,7);
        //    driver.Manage().Timeouts().ImplicitWait = waitTime;
        //}

        [Test]
        public void DressTest()
            
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            //title="Dresses"
            
            var categoryHeader = driver.FindElement(By.CssSelector("ul.sf-menu > li > a[title='Dresses']"));
            categoryHeader.Click();
            //Thread.Sleep(1000); czekanie ale nie ladne

            var productCounter = driver.FindElement(By.CssSelector(".heading-counter"));
            string text = productCounter.Text;

            // text.Contains("5");mozna tak sprawdzic czy tekst zawiera jakis tekst ale lepij uzyc ponizszego StringAssert
            StringAssert.Contains("5",text);


            //driver = new ChromeDriver;
            //var driver = new ChromeDriver();//tworzenie obiektu drivera, konstruktor
            //Assert.AreEqual(2,1);// error zatrzymuje aplikacje
            // driver.Quit();//close zamknie okno a quit drivera
        }

        [Test]
        public void ShirtTest()

        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            //title="Dresses"

            var categoryHeader = driver.FindElement(By.CssSelector("ul.sf-menu > li > a[title='T-shirts']"));
            categoryHeader.Click();
            //Thread.Sleep(1000); czekanie ale nie ladne

            var productCounter = driver.FindElement(By.CssSelector(".heading-counter"));
            string text = productCounter.Text;
            var webElements = driver.FindElements(By.CssSelector("div.product-container"));
            var actualElementCount = webElements.Count.ToString();//tostring - zrzucenie lcizby do stringa

            // text.Contains("5");mozna tak sprawdzic czy tekst zawiera jakis tekst ale lepij uzyc ponizszego StringAssert
            //StringAssert.Contains("7", text); proste prawdzenia czy ilosc zgadza sie z tym co podalismy
            StringAssert.Contains(actualElementCount, text);

            // text.Contains("5");mozna tak sprawdzic czy tekst zawiera jakis tekst ale lepij uzyc ponizszego StringAssert
           // StringAssert.Contains("1", text);


            //driver = new ChromeDriver;
            //var driver = new ChromeDriver();//tworzenie obiektu drivera, konstruktor
            //Assert.AreEqual(2,1);// error zatrzymuje aplikacje
            // driver.Quit();//close zamknie okno a quit drivera
        }

        [Test]
        public void WomanTest()

        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
           
            var categoryHeader = driver.FindElement(By.CssSelector("ul.sf-menu > li > a[title='Women']"));
            categoryHeader.Click();
         

            var productCounter = driver.FindElement(By.CssSelector(".heading-counter"));
            string text = productCounter.Text;

            var webElements = driver.FindElements(By.CssSelector("div.product-container"));
            var actualElementCount = webElements.Count.ToString();//tostring - zrzucenie lcizby do stringa

            StringAssert.Contains(actualElementCount, text);

         










        }

        //[TearDown]
        //public void TearDown()
        //{
        //   driver.Quit();
        //}
    }
}
