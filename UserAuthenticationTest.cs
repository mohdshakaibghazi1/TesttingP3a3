using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTest
{
    [TestFixture]
    public class UserAuthenticationTest
    {
        private UserAuthentication userAuthentication;
        [SetUp]
        public void Setup()
        {
            userAuthentication = new UserAuthentication();
        }
        [Test]
        public void TestUserRegistration() 
        {
            userAuthentication.RegisterUser("Manoj", "Manoj@123");
            Assert.IsTrue(userAuthentication.Login("Manoj", "Manoj@123"));
        }
        [Test]
        public void TestUserLogin()
        {
    
            userAuthentication.RegisterUser("Manoj", "Manoj@123");

     
            Assert.IsTrue(userAuthentication.Login("Manoj", "Manoj@123"));
            Assert.IsFalse(userAuthentication.Login("nag", "Manoj@12"));
            Assert.IsFalse(userAuthentication.Login("meg", "Manoj@"));
        }

        [Test]
        public void TestPasswordReset()
        {
           
            userAuthentication.RegisterUser("Manoj", "Manoj@123");

           
            userAuthentication.ResetPassword("Manoj", "Manoj@123");


            Assert.IsTrue(userAuthentication.Login("Manoj", "Manoj@123"));
        }
    }
}