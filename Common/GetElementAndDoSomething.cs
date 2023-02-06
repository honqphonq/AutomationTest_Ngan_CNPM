using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationTest_Ngan_CNPM.Common
{
    public class GetElementAndDoSomething
    {
        IWebDriver driver;
        public GetElementAndDoSomething(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void GetElementAndClick(By by)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            var element = wait.Until(c => c.FindElement(by));
            Actions action = new Actions(driver);
            action.Click(element);
            action.Perform();
            Thread.Sleep(2000);
        }
        public void GetElementAndClickRapid(By by)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            var element = wait.Until(c => c.FindElement(by));
            Actions action = new Actions(driver);
            action.Click(element);
            action.Perform();
        }
        public void GetElementAndSendKey(By by, string key)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            var element = wait.Until(c => c.FindElement(by));
            Actions action = new Actions(driver);
            action.SendKeys(element, key);
            action.Perform();
        }
        public void GetElementAndSendKeyAndEnter(By by, string key)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            var element = wait.Until(c => c.FindElement(by));
            Actions action = new Actions(driver);
            action.SendKeys(element, key);
            action.SendKeys(element, Keys.Enter);
            action.Perform();
            Thread.Sleep(2000);
        }

        public void GetElementAndEnter(By by)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            var element = wait.Until(c => c.FindElement(by));
            Actions action = new Actions(driver);
            action.SendKeys(element, Keys.ArrowRight);
            action.Perform();
            Thread.Sleep(2000);
        }

        public void GetElementAndCtrl(By by)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            var element = wait.Until(c => c.FindElement(by));
            element.SendKeys(Keys.Control + "a");
            Thread.Sleep(2000);
        }
        public void GetElementAndCtrlAndBackspace(By by)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            var element = wait.Until(c => c.FindElement(by));
            element.SendKeys(Keys.Control + "a");
            element.SendKeys(Keys.Backspace);
            Thread.Sleep(2000);
        }
        public void GetElementAndCtrlAndBackspaceGridField(By by)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            var element = wait.Until(c => c.FindElement(by));
            Actions action = new Actions(driver);
            action.SendKeys(element, (Keys.Control + "a") + (Keys.Backspace));
            action.Perform();
            Thread.Sleep(2000);
        }
        public void GetElementAndSendKeyAndArrowDownAndEnter(By by, string key)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            var element = wait.Until(c => c.FindElement(by));
            element.Click();
            element.SendKeys(key);
            Thread.Sleep(2000);
            element.SendKeys(Keys.ArrowDown);
            element.SendKeys(Keys.Enter);
        }

        public void GetElementAndSendRandomStringAndArrowDownAndEnter(By key, string name)
        {
            int length = 7;
            StringBuilder str_build = new StringBuilder();
            Random random = new Random();
            char letter;

            for (int i = 0; i < length; i++)
            {
                double flt = random.NextDouble();
                int shift = Convert.ToInt32(Math.Floor(25 * flt));
                letter = Convert.ToChar(shift + 65);
                str_build.Append(letter);
            }
            string value = name + " " + str_build.ToString();
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            var element = wait.Until(c => c.FindElement(key));
            element.SendKeys(value);
            Thread.Sleep(2000);
            element.SendKeys(Keys.ArrowDown);
            element.SendKeys(Keys.Enter);

        }
        public void GetElementAndSendRandomString(By key, string name)
        {
            int length = 7;
            StringBuilder str_build = new StringBuilder();
            Random random = new Random();
            char letter;

            for (int i = 0; i < length; i++)
            {
                double flt = random.NextDouble();
                int shift = Convert.ToInt32(Math.Floor(25 * flt));
                letter = Convert.ToChar(shift + 65);
                str_build.Append(letter);
            }
            string value = name + " " + str_build.ToString();
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            var element = wait.Until(c => c.FindElement(key));
            Actions action = new Actions(driver);
            action.SendKeys(element, value);
            action.Perform();
        }
        public void GetElementAndSendRandomNumber(By key, string numberText)
        {
            Random random = new Random();
            int number = random.Next(10, 1000);
            string numbersss = numberText + number.ToString();
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            var element = wait.Until(c => c.FindElement(key));
            Actions action = new Actions(driver);
            action.SendKeys(element, numbersss);
            action.Perform();

        }
        public void GetElementAndSendRandomEmail(By key)
        {
            int length = 7;
            StringBuilder str_build = new StringBuilder();
            Random random = new Random();
            char letter;

            for (int i = 0; i < length; i++)
            {
                double flt = random.NextDouble();
                int shift = Convert.ToInt32(Math.Floor(25 * flt));
                letter = Convert.ToChar(shift + 65);
                str_build.Append(letter);
            }
            string value = str_build.ToString() + "@gmail.com";
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            var element = wait.Until(c => c.FindElement(key));
            element.SendKeys(value);
        }
        public void GetElementAndMoveTo(By by)
        {
            IWebElement element = driver.FindElement(by);
            Actions action = new Actions(driver);
            action.MoveToElement(element);
            action.Perform();
        }
        public void GetElementAndSelectRandomElement(int number1, int number2)
        {
            Random random = new Random();
            int number = random.Next(number1, number2);
            string xpathAddress = "(//li[@role='option'])" + "[" + number + "]";
            By by = By.XPath(xpathAddress);
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            var element = wait.Until(c => c.FindElement(by));
            element.Click();
            Thread.Sleep(2000);
        }
        public void GetElementAndDragAndDropElement(By from, By to)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            var drag = wait.Until(c => c.FindElement(from));
            var drop = wait.Until(c => c.FindElement(to));
            Actions action = new Actions(driver);
            action.DragAndDrop(drag, drop).Perform();
            Thread.Sleep(2000);

        }
        public void GetElementAndDragAndDropElement2(By from, int x, int y)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            var drag = wait.Until(c => c.FindElement(from));
            Actions action = new Actions(driver);
            action.DragAndDropToOffset(drag, x, y).Build().Perform();
            Thread.Sleep(2000);
        }
        public void GetElementAndShowInfor(By by)
        {
            IWebElement element = driver.FindElement(by);
            Console.WriteLine(element.Text);
        }
    }
}
