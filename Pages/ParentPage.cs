using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Valtech.Pages
{
    class ParentPage
    {
        By title = By.XPath("//header[contains(@class,'page-header')]/h1");

        public bool DoesTitleExist(IWebDriver driver)
        {
            bool result = true;

            try
            {
                driver.FindElement(title);
            }
            catch (NoSuchElementException ex)
            {
                result = false;
            }

            return result;
        }
    }
}
