using AutomationTest_Ngan_CNPM.Common;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTest_Ngan_CNPM.POM.UserAdmin_POM
{
    public class CreateUserAdminPOM
    {
        IWebDriver driver;
        By taoTaiKhoanAdmin = By.XPath("//a[contains(.,'Tạo tài khoản admin')]");
        By tenDangNhap = By.XPath("//input[@id='username_useradmin']");
        By matKhau = By.XPath("//input[@id='password_useradmin']");
        By nhapLaiMatKhau = By.XPath("//input[@id='re_password_admin']");
        By email = By.XPath("//input[@type='email']");
        By soDienThoai = By.XPath("//input[@id='phone_useradmin']");
        By taoTaiKhoanButton = By.XPath("//button[@type='submit']");
        By successNoti = By.XPath("//strong[contains(.,'Tạo thành công')]");
        By requiredText = By.XPath("//span[contains(.,'Tên đăng nhập không được để trống')]");
        By invalidField = By.XPath("//span[contains(.,'validation.numeric')]");
        By sameUserName = By.XPath("//span[contains(.,'Tên đăng nhập đã được dùng')]");

        public CreateUserAdminPOM(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void CreateUserAdminSuccess()
        {
            var getElement = new GetElementAndDoSomething(driver);
            getElement.GetElementAndClick(taoTaiKhoanAdmin);
            getElement.GetElementAndCtrlAndBackspace(tenDangNhap);
            getElement.GetElementAndSendRandomString(tenDangNhap, "AutomationTest_");
            getElement.GetElementAndCtrlAndBackspace(matKhau);
            getElement.GetElementAndSendKey(matKhau, "123456");
            getElement.GetElementAndSendKey(nhapLaiMatKhau, "123456");
            getElement.GetElementAndSendRandomEmail(email);
            getElement.GetElementAndSendRandomNumber(soDienThoai, "095246");
            getElement.GetElementAndClick(taoTaiKhoanButton);
            var check = new CheckElementDisplayed(driver);
            check.CheckElementDisplay(successNoti);
        }

        public void CreateUserAdminWithInvalidField()
        {
            var getElement = new GetElementAndDoSomething(driver);
            getElement.GetElementAndClick(taoTaiKhoanAdmin);
            getElement.GetElementAndCtrlAndBackspace(tenDangNhap);
            getElement.GetElementAndSendRandomString(tenDangNhap, "AutomationTest_");
            getElement.GetElementAndCtrlAndBackspace(matKhau);
            getElement.GetElementAndSendKey(matKhau, "123456");
            getElement.GetElementAndSendKey(nhapLaiMatKhau, "123456");
            getElement.GetElementAndSendRandomEmail(email);
            getElement.GetElementAndSendKey(soDienThoai, "adfasdfasdf");
            getElement.GetElementAndClick(taoTaiKhoanButton);
            var check = new CheckElementDisplayed(driver);
            check.CheckElementDisplay(invalidField);
        }

        public void CreateUserAdminWithoutRequiredField()
        {
            var getElement = new GetElementAndDoSomething(driver);
            getElement.GetElementAndClick(taoTaiKhoanAdmin);
            getElement.GetElementAndCtrlAndBackspace(tenDangNhap);
            getElement.GetElementAndCtrlAndBackspace(matKhau);
            getElement.GetElementAndSendKey(matKhau, "123456");
            getElement.GetElementAndSendKey(nhapLaiMatKhau, "123456");
            getElement.GetElementAndSendRandomEmail(email);
            getElement.GetElementAndSendKey(soDienThoai, "0952467156");
            getElement.GetElementAndClick(taoTaiKhoanButton);
            var check = new CheckElementDisplayed(driver);
            check.CheckElementDisplay(requiredText);
        }

        public void CreateUserAdminWithSameUserName()
        {
            var getElement = new GetElementAndDoSomething(driver);
            getElement.GetElementAndClick(taoTaiKhoanAdmin);
            getElement.GetElementAndCtrlAndBackspace(tenDangNhap);
            getElement.GetElementAndSendKey(tenDangNhap, "admin");
            getElement.GetElementAndCtrlAndBackspace(matKhau);
            getElement.GetElementAndSendKey(matKhau, "123456");
            getElement.GetElementAndSendKey(nhapLaiMatKhau, "123456");
            getElement.GetElementAndSendRandomEmail(email);
            getElement.GetElementAndSendKey(soDienThoai, "0952467156");
            getElement.GetElementAndClick(taoTaiKhoanButton);
            var check = new CheckElementDisplayed(driver);
            check.CheckElementDisplay(sameUserName);
        }
    }
}
