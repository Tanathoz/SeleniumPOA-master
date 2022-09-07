using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;

namespace SeleniumPractice
{
    class LoginPageObject
    {
        public LoginPageObject()
        {
            //PageFactory.InitElements(PropiertiesCollection.driver, this);
        }

       // [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement txtPassword { get; set; }

        //[FindsBy(How = How.Name, Using = "UserName")]
        public IWebElement txtUserName { get; set; }

//        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement btnLogin { get; set; }

        public EAPageObject Login(string userName, string password) {

            txtUserName.EnterText(userName);
            txtPassword.EnterText(password);
            btnLogin.Submit();

            //return EAPageObject
            return new EAPageObject();
        }
    }
}
