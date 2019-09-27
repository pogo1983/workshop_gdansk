using OpenQA.Selenium;
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
        private By submitButtonLocator = By.CssSelector("#submitMessage");
        public ContactUsPage(IWebDriver driver)//konstruktor do tworzenia obiektu strony
        {
            this.driver = driver;
        }

        public void GoToPage()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=contact");
        }

        public void ClickSubmitButton()
        {
            driver.FindElement(submitButtonLocator).Click();
        }
    }


}
