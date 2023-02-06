using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTest_Ngan_CNPM.FileBaseTest
{
    public class BaseTestCustomer
    {
        public IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver("C:\\Users\\Admin\\Downloads\\chromedriver_win32");
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:3000/login");
        }

        [TearDown]
        public void Close()
        {
            driver.Close();
            driver.Quit();
        }

    }
}
