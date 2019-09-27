using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.Pages
{
    public class HomePage
    {
        private IWebDriver driver;
        private WebDriverWait waitDriver;
        private By WomenButtonLocator = By.CssSelector("#submitMessage");
        private By DressButtonLocator = By.CssSelector("ul.sf-menu > li > a[title='Dresses']");
        private By TshirtButtonLocator = By.CssSelector("ul.sf-menu > li > a[title='Women']");
        //private By errorMessageLocator = By.CssSelector(".alert");

        public HomePage(IWebDriver driver)//konstruktor do tworzenia obiektu strony
        {
            this.driver = driver;
            waitDriver = new WebDriverWait(driver, new System.TimeSpan(0, 0, 15));
        }
        
        public void GoToPage()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }

        public void ClickWomenButton()
        {
            driver.FindElement(WomenButtonLocator).Click();
        }
        public void ClickDressButton()
        {
            driver.FindElement(DressButtonLocator).Click();
        }
        public void ClickTsirtButton()
        {
            driver.FindElement(TshirtButtonLocator).Click();
        }



    }
}
