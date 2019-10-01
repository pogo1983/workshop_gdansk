using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Selenium.Pages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium
{
    [TestFixture]
    public class ContactUsTest:TestBase
    {

        ContactUsPage sut;

        [SetUp]
        public void ContactUsSetup()
        {
            sut = new ContactUsPage(driver);
            //driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            sut.GoToPage();
        }

        [Test]
        public void SendFormWithoutData()

        {

           
            sut.ClickSubmitButton();
            var errorMessage = sut.GetErrorMessageText();
            Assert.IsTrue(sut.IsErrorMessageDisplayed(), errorMessage);

         
        }

       
        

    }
}
