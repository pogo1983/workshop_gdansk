using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace Selenium
{
    [TestFixture]
    public class CategoriesTestPOP:TestBase
    {
        CategoriesTestPOP sut;

        [SetUp]
        public void CategoriesSetup()
        {
            sut = new CategoriesTestPOP(driver);
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
           
        }

        [Test]
        public void WomanTest3()

        {
           

        }

   
    }
}
