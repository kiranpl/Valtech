using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Valtech.Pages
{
    class Contact
    {
        By office = By.XPath("//ul[@class='contactcities']/li");

        public int GetOfficeCount(IWebDriver driver)
        {
            return driver.FindElements(office).Count;
        }
    }
}
