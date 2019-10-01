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
            sut.CountItemsOnPage();
            var errorMessage = sut.actualElementCount();
            StringAssert.Contains(actualElementCount, text);
        }

        [Test]
        public void ShirtTest2()

        {
           
        }

        [Test]
        public void WomanTest3()

        {
           

        }

   
    }
}
