﻿using NUnit.Framework;
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

            //var categoryHeader = driver.FindElement(By.CssSelector("#contact-link > a:nth-child(1)"));
            // categoryHeader.Click();//to byl przypadelk, gdy otwieralem glowna strone a potem contact us

            // var contactSend = driver.FindElement(By.CssSelector("#submitMessage"));
            // contactSend.Click(); //zamienoine na sut.ClickSubmitButton();
            sut.ClickSubmitButton();

            //WebDriverWait waitDriver = new WebDriverWait(driver, new System.TimeSpan(0, 0, 15));
            //var checkError = waitDriver.Until(ExpectedConditions.ElementExists(By.CssSelector(".alert")));//oczekuje na przycisk

            //var checkError = driver.FindElement(By.CssSelector(".alert"));
            // string text = checkError.Text;//zamienione na var errorMessage = sut.GetErrorMessage();
            var errorMessage = sut.GetErrorMessageText();


            //StringAssert.Contains("Invalid email address.", errorMessage);
            Assert.IsTrue(sut.IsErrorMessageDisplayed(), errorMessage);

           // Assert.That(checkError.Text, Is.EqualTo("Invalid email address."));//tego sie uzywa bo wygodniejsze

            //driver = new ChromeDriver;
            //var driver = new ChromeDriver();//tworzenie obiektu drivera, konstruktor
            //Assert.AreEqual(2,1);// error zatrzymuje aplikacje
            // driver.Quit();//close zamknie okno a quit drivera
        }

       
        //public void StremWriterExample()
        //{
        //    using sw = new StreamWriter(@"C:\workspace\git\workshop_gdansk\pogo.txt)
        //}

    }
}
