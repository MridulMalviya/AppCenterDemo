using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest;

namespace AppCenterDemo.UITest
{
    [TestFixture(Platform.Android)]
    //[TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp _app;
        Platform _platform;

        public Tests(Platform platform)
        {
            this._platform = platform;
            _app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void A_MainPage_NavigateLoginPage()
        {
            _app.Tap("Login");

            Assert.IsTrue(_app.WaitForElement("Sign in").Any());
        }

        [Test]
        public void B_LoginPage_LoginWithoutCredentials()
        {
            _app.Tap("Sign in");

            var result = _app.WaitForElement("OK");

            _app.Tap("OK");

            Assert.IsTrue(result.Any());
        }

        [Test]
        public void C_LoginPage_LoginSuccessfully()
        {
            _app.EnterText("username", "bryan@gmail.com");
            _app.EnterText("password", "anything");
            _app.Tap("Sign in");

            Assert.IsTrue(_app.WaitForElement("browse").Any());
        }
    }
}
