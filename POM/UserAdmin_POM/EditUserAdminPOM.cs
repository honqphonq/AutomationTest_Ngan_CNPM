using AutomationTest_Ngan_CNPM.Common;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTest_Ngan_CNPM.POM.UserAdmin_POM
{
    public class EditUserAdminPOM
    {
        IWebDriver driver;
        By taikhoanquantri = By.XPath("//a[contains(.,'Tài khoản quản trị')]");
        By edit1 = By.XPath("(//i[contains(@class,'fa fa-pencil-square-o')])[5]");
        By tenDangNhap = By.XPath("//input[@id='username_useradmin']");
        By email = By.XPath("//input[@id='email_useradmin']");
        By soDienThoai = By.XPath("//input[@id='phone_useradmin']");
        By editButton = By.XPath("//button[@type='submit']");
        By successNoti = By.XPath("//strong[contains(.,'Cập nhật thành công')]");

        public EditUserAdminPOM(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void EditSuccess()
        {
            //click taikhoanquantri
            var getElement = new GetElementAndDoSomething(driver);
            getElement.GetElementAndClick(taikhoanquantri);
            getElement.GetElementAndClick(edit1);
            //update user-admin
            getElement.GetElementAndCtrlAndBackspace(tenDangNhap);
            getElement.GetElementAndSendRandomString(tenDangNhap, "Admin-");
            getElement.GetElementAndCtrlAndBackspace(email);
            getElement.GetElementAndSendRandomEmail(email);
            getElement.GetElementAndCtrlAndBackspace(soDienThoai);
            getElement.GetElementAndSendKey(soDienThoai, "0957286266");
            getElement.GetElementAndClick(editButton);
            //check noti
            var check = new CheckElementDisplayed(driver);
            check.CheckElementDisplay(successNoti);
        }
    }
}
