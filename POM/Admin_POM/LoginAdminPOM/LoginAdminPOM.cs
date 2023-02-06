using AutomationTest_Ngan_CNPM.Common;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTest_Ngan_CNPM.POM.Admin_POM.LoginAdminPOM
{
    public class LoginAdminPOM 
    {
        IWebDriver driver;
        By username = By.XPath("(//input[@name='username'])[1]");
        By password = By.XPath("(//input[@name='password'])[1]");
        By loginButton = By.XPath("(//button[@type='submit'])[1]");
        By successNoti = By.XPath("//h6[contains(.,'DASHBOARD')]");
        By requiredField = By.XPath("(//span[contains(.,'Tên đăng nhập không được để trống')])[1]");
        By invalidField = By.XPath("(//h5[contains(.,'Tài khoản hoặc mật khẩu sai, vui lòng nhập lại!')])[1]");
        public LoginAdminPOM(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void LoginSuccess()
        {
            var getElement = new GetElementAndDoSomething(driver);
            getElement.GetElementAndSendKey(username, "admin");
            getElement.GetElementAndSendKey(password, "123456");
            getElement.GetElementAndClick(loginButton);
            var check = new CheckElementDisplayed(driver);
            check.CheckElementDisplay(successNoti);
        }

        public void LoginWithInvalidField()
        {
            var getElement = new GetElementAndDoSomething(driver);
            getElement.GetElementAndSendKey(username, "admin123");
            getElement.GetElementAndSendKey(password, "123456");
            getElement.GetElementAndClick(loginButton);
            var check = new CheckElementDisplayed(driver);
            check.CheckElementDisplay(invalidField);
        }

        public void LoginWithRequiredField()
        {
            var getElement = new GetElementAndDoSomething(driver);
            getElement.GetElementAndSendKey(password, "123456");
            getElement.GetElementAndClick(loginButton);
            var check = new CheckElementDisplayed(driver);
            check.CheckElementDisplay(requiredField);
        }
    }
}
