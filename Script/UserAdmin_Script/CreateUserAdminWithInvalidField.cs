using AutomationTest_Ngan_CNPM.FileBaseTest;
using AutomationTest_Ngan_CNPM.POM.Admin_POM.LoginAdminPOM;
using AutomationTest_Ngan_CNPM.POM.UserAdmin_POM;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTest_Ngan_CNPM.Script.UserAdmin_Script
{
    public class CreateUserAdminWithInvalidField : BaseTestAdmin
    {
        [Test, Category("Create User Admin")]
        public void CreateUserAdmin()
        {
            //login
            var login = new LoginAdminPOM(driver);
            login.LoginSuccess();
            //create
            var create = new CreateUserAdminPOM(driver);
            create.CreateUserAdminWithInvalidField();
        }
    }
}
