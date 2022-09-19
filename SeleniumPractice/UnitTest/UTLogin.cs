using System;
using System.Collections.Generic;
using System.IO;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Configuration;
using OpenQA.Selenium.Chrome;
using SeleniumPractice.DataPool;
using SeleniumPractice.Entities;
using SeleniumPractice.Flujos;


namespace SeleniumPractice.UnitTest
{
    public class UTLogin
    {
        FLLogin objLogin = new FLLogin();
        IWebDriver driver = null;
       // DAOUsuario objUsuario = new DAOUsuario();
        List<EntLogin> lstLogin = null;
        string fileName = Path.GetFullPath(ConfigurationManager.AppSettings["DataPool"]);
        string usuario = ConfigurationManager.AppSettings["Usuario"];
        string password = ConfigurationManager.AppSettings["Password"];
        string url = ConfigurationManager.AppSettings["AmbienteQA"];

        [SetUp]
        public void Inicializar()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(25);
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
        }

        [Test]
        public void IniciarSesion()
        {
            //lstLogin = objUsuario.obtenerLogin(fileName);
            bool resultado = false;
            objLogin.Login(driver, usuario, password);
            resultado = objLogin.DevolverResultado();
            Assert.AreEqual(true, resultado);
        }

        [Test]
        public void PasswordFail()
        {
            bool resultado = false;
            objLogin.LoginFail(driver, "sdsd", "Fake1234");
            resultado = objLogin.DevolverResultado();
            Assert.AreEqual(true, resultado);
        }


        [TearDown]
        public void CleanUp()
        {
            driver.Close();
            Console.WriteLine("close browser");
        }
    }
}
