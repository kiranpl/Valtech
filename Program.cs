using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;

using Valtech.Pages;

namespace Valtech
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();

            driver.Url = "http://www.valtech.com";

            //Latest News section
            Home home = new Home();
            if (!home.DoesLatestNewsExist(driver))
            {
                Console.WriteLine("FAIL: Latest News section doesn't exist on home page!");
            }

            //Services section
            home.GotoServices(driver);
            Services services = new Services();

            if (services.DoesTitleExist(driver))
            {
                Console.WriteLine("FAIL: Services title doesn't exist on services page!");
            }

            home.GoHome(driver);

            //Insights section
            home.GotoInsights(driver);
            Insights insights = new Insights();

            if (insights.DoesTitleExist(driver))
            {
                Console.WriteLine("FAIL: Insights title doesn't exist on insights page!");
            }

            home.GoHome(driver);

            //Jobs section
            home.GotoCareers(driver);
            Jobs careers = new Jobs();

            if (insights.DoesTitleExist(driver))
            {
                Console.WriteLine("FAIL: Careers title doesn't exist on careers page!");
            }

            home.GoHome(driver);

            //Contact section
            home.GotoContact(driver);
            Contact contact = new Contact();

            Console.WriteLine("Valtech Office Count:" + contact.GetOfficeCount(driver));

            //driver.Quit();
        }
    }
}
