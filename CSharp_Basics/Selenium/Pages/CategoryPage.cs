﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Selenium.Pages
{
    public class CategoryPage
    {
        private IWebDriver driver;
        private WebDriverWait waitDriver;
        private By ItemCounter = By.CssSelector("div.product-container");
        private By ItemCounterLocator = By.CssSelector(".heading-counter");

        public CategoryPage(IWebDriver driver)//konstruktor do tworzenia obiektu strony
        {
            this.driver = driver;
            waitDriver = new WebDriverWait(driver, new System.TimeSpan(0, 0, 25));
        }

        public void GoToPage()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }

        public string GetDispNumberOfProducts()
        {
            var productcounter = driver.FindElement(ItemCounterLocator);
            return productcounter.Text;
        }

        public string CountItemsOnPage()
        {
            var webElements = driver.FindElements(ItemCounter);
            return webElements.Count.ToString();
           // var actualElementCount = webElements.Count.ToString();//tostring - zrzucenie lcizby do stringa

            //int count = 0;
            //for (int i= 0; i < 100; i++) 
            //{
            //    int currentCount = driver.FindElements(By.CssSelector("div.product-container")).Count;
            //    if (currentCount!=count)
            //    {
            //        count = currentCount;
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}
            //var actualElementCount = count.ToString();//tostring - zrzucenie lcizby do stringa
        }

    }
}
