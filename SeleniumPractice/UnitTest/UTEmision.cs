using System;
using System.Collections.Generic;
using System.IO;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Configuration;
using SeleniumPractice.DataPool;
using SeleniumPractice.Entities;
using SeleniumPractice.Flujos;
using OpenQA.Selenium.Chrome;
using System.Reflection;
using System.Diagnostics;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Firefox;

namespace SeleniumPractice.UnitTest
{
    public class UTEmision
    {
        FLLogin objLogin = new FLLogin();
        //FLUsuario objUsuario = new FLUsuario();
        FLEmitir objEmitir = new FLEmitir();
        DAOEmitir DaoEmitir = new DAOEmitir();
        IWebDriver driver = null;
        List<EntComprobante> lstComprobantes = null;
        bool resultado = false;
        public static string seleniumHub = "http://localhost:4444/wd/hub";
       // string folder = Path.GetFullPath(@"\..\..\..\Repositorios\SeleniumPOA-master\SeleniumPOA-master\SeleniumPractice\DataPool\Docs\PortalEmision.xlsx");
        static string patho = Path.GetDirectoryName( System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
        string fileName =  new Uri(patho.Replace("\\bin\\Debug", "\\DataPool\\Docs\\PortalEmision.xlsx")).LocalPath;
        //string fileName = Path.GetFullPath(ConfigurationManager.AppSettings["DataPool"]);
        string pathDriver = new Uri(patho.Replace("\\SeleniumPractice\\bin\\Debug", "\\references")).LocalPath;
        string usuario = ConfigurationManager.AppSettings["Usuario"];
        string password = ConfigurationManager.AppSettings["Password"];
        string url = ConfigurationManager.AppSettings["AmbienteQA"];
      
        [SetUp]
        public void Inicializar()
        {
            lstComprobantes = DaoEmitir.obtenerComprobantesExcel(fileName);
           // driver = iniciarNavegador();
            driver = iniciarNavegadorMoziilla();
            //driver = iniciarNavegadorIE();
            objLogin.Login(driver, usuario, password);

        }

        [Test]
        public void EmitirCFDI()
        {
            bool resultado = false;
            objEmitir.navegarEmitir(driver);
            for (int i = 0; i < 1; i++)
            {
                objEmitir.emitirCFDI(driver, lstComprobantes[0]);
            }
            resultado = objEmitir.DevolverResultado();
            Assert.AreEqual(true, resultado);
        }

        [Test]
        public void EmitirCFDIEgresoPPD()
        {
            bool resultado = false;
            objEmitir.navegarEmitir(driver);
            objEmitir.emitirCFDI(driver, lstComprobantes[1]);
            resultado = objEmitir.DevolverResultado();
            Assert.AreEqual(true, resultado);
        }

        [Test]
        public void EmitirCFDIIngreso99()
        {
            bool resultado = false;
            objEmitir.navegarEmitir(driver);
            for (int i = 0; i < 1; i++)
            {

                objEmitir.emitirCFDI(driver, lstComprobantes[2]);
            }

            resultado = objEmitir.DevolverResultado();
            Assert.AreEqual(true, resultado);
        }

        [Test]
        public void EmitirReciboHonorarios()
        {
            bool resultado = false;
            objEmitir.navegarEmitir(driver);
            objEmitir.emitirCFDI(driver, lstComprobantes[9]);
            resultado = objEmitir.DevolverResultado();
            Assert.AreEqual(true, resultado);
        }


        [Test]
        public void EmitirReciboArrendatario()
        {
            bool resultado = false;
            objEmitir.navegarEmitir(driver);
            objEmitir.emitirCFDI(driver, lstComprobantes[10]);
            resultado = objEmitir.DevolverResultado();
            Assert.AreEqual(true, resultado);
        }

        [Test]
        public void EmitirNotaDebito()
        {
            bool resultado = false;
            objEmitir.navegarEmitir(driver);
            objEmitir.emitirCFDI(driver, lstComprobantes[11]);
            resultado = objEmitir.DevolverResultado();
            Assert.AreEqual(true, resultado);
        }

        [Test]
        public void EmitirEstadoCuenta()
        {
            bool resultado = false;
            objEmitir.navegarEmitir(driver);
            objEmitir.emitirCFDI(driver, lstComprobantes[12]);
            resultado = objEmitir.DevolverResultado();
            Assert.AreEqual(true, resultado);
        }

        [Test]
        public void EmitirDonatarias()
        {
            bool resultado = false;
            objEmitir.navegarEmitir(driver);
            objEmitir.emitirCFDI(driver, lstComprobantes[13]);
            resultado = objEmitir.DevolverResultado();
            Assert.AreEqual(true, resultado);
        }


        [Test]
        public void EmitirCartaPorte()
        {
            bool resultado = false;
            objEmitir.navegarEmitir(driver);
            objEmitir.emitirCFDI(driver, lstComprobantes[14]);
            resultado = objEmitir.DevolverResultado();
            Assert.AreEqual(true, resultado);
        }

        [Test]
        public void EmitirComprobantePagoPlazos()
        {
            bool resultado = false;
            objEmitir.navegarEmitir(driver);
            objEmitir.emitirCFDI(driver, lstComprobantes[15]);
            resultado = objEmitir.DevolverResultado();
            Assert.AreEqual(true, resultado);
        }

        [Test]
        public void EmitirAseguradora()
        {
            bool resultado = false;
            objEmitir.navegarEmitir(driver);
            objEmitir.emitirCFDI(driver, lstComprobantes[16]);
            resultado = objEmitir.DevolverResultado();
            Assert.AreEqual(true, resultado);
        }

        [Test]
        public void EmitirFactura()
        {
            bool resultado = false;
            objEmitir.navegarEmitirFactura(driver);
            objEmitir.emitirFacturaGlobal(driver, lstComprobantes[8]);
            resultado = objEmitir.DevolverResultado();
            Assert.AreEqual(true, resultado);
        }

        [Test]
        public void EmitirRecepcionPago()
        {
            bool resultado = false;
            objEmitir.navegarEmitirRecepcion(driver);
            objEmitir.emitirRecepcionPago(driver, lstComprobantes[0]);
            resultado = objEmitir.DevolverResultado();
            Assert.AreEqual(true, resultado);
        }

        [Test]
        public void EmitirMultiplesRecepcionPago()
        {
            bool resultado = false;
            List<ComplementoPago> lstComplementos = DaoEmitir.obtenerComplementosPago(fileName);
            objEmitir.navegarEmitirRecepcion(driver);
            for (int i = 750; i < 751; i++)
            {
                lstComprobantes[0].ComplementoPago = lstComplementos[i];
                objEmitir.emitirRecepcionPago(driver, lstComprobantes[0]);
            }

            resultado = objEmitir.DevolverResultado();
            Assert.AreEqual(true, resultado);
        }

        [Test]
        public void EmitirNomina()
        {
            bool resultado = false;
            objEmitir.navegarEmitirNomina(driver);
            objEmitir.emitirNomina(driver, lstComprobantes[1]);
            resultado = objEmitir.DevolverResultado();
            Assert.AreEqual(true, resultado);
        }

        [Test]
        public void EmitirINE()
        {
            bool resultado = false;
            objEmitir.navegarEmitirINE(driver);
            objEmitir.emitirINE(driver, lstComprobantes[0]);
            resultado = objEmitir.DevolverResultado();
            Assert.AreEqual(true, resultado);
        }
        [Test]
        public void EmitirECC12()
        {
            bool resultado = false;
            objEmitir.navegarEmitirECC12(driver);
            objEmitir.emitirECC12(driver, lstComprobantes[0]);
            resultado = objEmitir.DevolverResultado();
            Assert.AreEqual(true, resultado);
        }

        [Test]
        public void EmitirComercio()
        {
            bool resultado = false;
            objEmitir.navegarEmitirComercio(driver);
            objEmitir.emitirComercioExterior(driver, lstComprobantes[3]);
            resultado = objEmitir.DevolverResultado();
            Assert.AreEqual(true, resultado);
        }

        [Test]
        public void EmitirHidrocarburo()
        {
            bool resultado = false;
            objEmitir.navegarEmitirHidrocarburos(driver);
            objEmitir.emitirHidrocarburos(driver, lstComprobantes[4]);
            resultado = objEmitir.DevolverResultado();
            Assert.AreEqual(true, resultado);
        }

        public IWebDriver iniciarNavegador()
        {
            
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("no-sandbox");
          //  options.BinaryLocation = @"C:\\Repositorios\\SeleniumPOA-master\\SeleniumPOA-master\\references\\chrome.exe";
            //driver = new ChromeDriver(ChromeDriverService.CreateDefaultService(),options ,TimeSpan.FromMinutes(3));
            driver = new ChromeDriver();
            driver = new RemoteWebDriver(new Uri(seleniumHub),options);
            
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(25);
            
            //  driver.Navigate().GoToUrl("https://oat.reachcore.com/portal/");
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            return driver;
        }

        public IWebDriver iniciarNavegadorMoziilla()
        {
            FirefoxOptions options = new FirefoxOptions();
            //options.AddArgument("no-sandbox");
            //options.BrowserExecutableLocation = @"C:\\Users\\Cuauhtemoc.Alcocer\\AppData\\Local\\Mozilla Firefox\\firefox.exe";
            //driver = new FirefoxDriver(FirefoxDriverService.CreateDefaultService(), options, TimeSpan.FromMinutes(3));
            driver = new RemoteWebDriver(new Uri(seleniumHub), options);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(25);
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            return driver;
        }

        public IWebDriver iniciarNavegadorIE()
        {
          //  driver = new InternetExplorerDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(25);
            //  driver.Navigate().GoToUrl("https://oat.reachcore.com/portal/");
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            return driver;
        }


        [TearDown]
        public void CleanUp()
        {
            driver.Close();
            Console.WriteLine("close browser");
        }
    }
}
