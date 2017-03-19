using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Valtech.Pages
{
    class Home
    {
        By services = By.LinkText("Services");
        By insights = By.LinkText("Insights");
        By careers = By.LinkText("Careers");
        By contact = By.XPath("//i[@class='icons glyph']");
        By news = By.XPath("//h2[@class='block-header__heading']");

        public void GotoServices(IWebDriver driver)
        {
            driver.FindElement(services).Click();
        }

        public void GotoInsights(IWebDriver driver)
        {
            driver.FindElement(insights).Click();
        }

        public void GotoCareers(IWebDriver driver)
        {
            driver.FindElement(careers).Click();
        }

        public void GotoContact(IWebDriver driver)
        {
            driver.FindElement(contact).Click();
        }

        public void GoHome(IWebDriver driver)
        {
            driver.Url = "http://www.valtech.com";
        }

        public bool DoesLatestNewsExist(IWebDriver driver)
        {
            bool result = true;

            try
            {
                driver.FindElement(news);
            }
            catch (NoSuchElementException ex)
            {
                result = false;
            }

            return result;
        }
    }
}
