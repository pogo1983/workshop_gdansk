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
        public ContactUsPage(IWebDriver driver)//konstruktor do tworzenia obiektu strony
        {
            this.driver = driver;
        }
    }
}
