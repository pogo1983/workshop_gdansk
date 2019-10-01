using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium.Pages;
using System;
using System.Threading;

namespace Selenium
{
    [TestFixture]
    public class CategoriesTestPOP:TestBase
    {
        CategoryPage sut;

        [SetUp]
        public void CategoriesSetup()
        {
            sut = new CategoryPage(driver);
            //driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            sut.GoToPage();
        }

        [Test]
        public void DressTest1()
            
        {
         
        }

        [Test]
        public void ShirtTest2()

        {
            sut.GoToPage();
            var categoryHeader = driver.FindElement(By.CssSelector("ul.sf-menu > li > a[title='T-shirts']"));
            categoryHeader.Click();
            string textWitCountedItems = sut.GetDispNumberOfProducts();
            string countOfItems = sut.CountItemsOnPage();
            StringAssert.Contains(countOfItems, textWitCountedItems);
        }

        [Test]
        public void WomanTest3()

        {
           

        }

   
    }
}
