using AutomationTest_Ngan_CNPM.FileBaseTest;
using AutomationTest_Ngan_CNPM.POM.Admin_POM.LoginAdminPOM;
using AutomationTest_Ngan_CNPM.POM.UserAdmin_POM;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationTest_Ngan_CNPM.Script.UserAdmin_Script
{
    public class EditUserAdminSuccess : BaseTestAdmin
    {
        [Test, Category("Edit User Admin")]
        public void EditUser()
        {
            //login
            var login = new LoginAdminPOM(driver);
            login.LoginSuccess();
            Thread.Sleep(3000);
            //edit
            var edit = new EditUserAdminPOM(driver);
            edit.EditSuccess();
        }
    }
}
