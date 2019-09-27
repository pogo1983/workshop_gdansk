using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.Pages
{
    public class ContactUsPage
    {
        private IWebDriver driver;
        private WebDriverWait waitDriver;
        private By submitButtonLocator = By.CssSelector("#submitMessage");
        private By errorMessageLocator = By.CssSelector(".alert");

        public ContactUsPage(IWebDriver driver)//konstruktor do tworzenia obiektu strony
        {
            this.driver = driver;
            waitDriver = new WebDriverWait(driver, new System.TimeSpan(0, 0, 15));
        }

        public bool IsErrorMessageDisplayed()
        {
            var errorMessage = waitDriver.Until(ExpectedConditions.ElementExists(errorMessageLocator));
            return errorMessage.Displayed;
        }
        public void GoToPage()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=contact");
        }

        public void ClickSubmitButton()
        {
            driver.FindElement(submitButtonLocator).Click();
        }


        public string GetErrorMessageText()
        {
            WebDriverWait waitDriver = new WebDriverWait(driver, new System.TimeSpan(0, 0, 15));
            var checkError = waitDriver.Until(ExpectedConditions.ElementExists(errorMessageLocator));//oczekuje na przycisk
            return checkError.Text;

        }
    }


}
