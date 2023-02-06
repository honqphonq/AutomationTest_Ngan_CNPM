using AutomationTest_Ngan_CNPM.FileBaseTest;
using AutomationTest_Ngan_CNPM.POM.Admin_POM.LoginAdminPOM;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTest_Ngan_CNPM.Script.Admin_Script
{
    public class LoginSuccess : BaseTestAdmin
    {
        [Test, Category("Login Admin")]
        public void Login()
        {
            var login = new LoginAdminPOM(driver);
            login.LoginSuccess();
        }
    }
}
