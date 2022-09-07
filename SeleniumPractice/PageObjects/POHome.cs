using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
namespace SeleniumPractice.PageObjects
{
    public class POHome
    {
        public IWebElement MenuInicio(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("Inicio"));
            return element;
        }

        public IWebElement MenuCuenta(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("Micuenta"));
            return element;
        }

        public IWebElement MenuEmitir(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("Emitir"));
            return element;
        }

        public IWebElement MenuBusquedas(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("Busquedas"));
            return element;
        }

        public IWebElement MenuArchivoIntegracion(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("cargaarchivos"));
            return element;
        }

        public IWebElement MenuMonitor(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("MonitorAI"));
            return element;
        }

        public IWebElement MenuConsultas(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("CancelacionReceptor"));
            return element;
        }

        public IWebElement LinkUsuarios(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//a[contains(text(),'Usuarios de mi cuenta')]"));
            return element;
        }
        public IWebElement LinkEmisionContratos(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//a[contains(text(),'Emisión de comprobantes fiscales')]"));
            return element;
        }

        public IWebElement LinkCuentaReachCore(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//a[contains(text(),'Mi cuenta Reachcore')]"));
            return element;
        }

        public IWebElement LinkMisServicios(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//a[contains(text(),'Mis servicios')]"));
            return element;
        }

        public IWebElement LinkRazonesSociales(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//a[contains(text(),'Mis razones sociales')]"));
            return element;
        }

        public IWebElement LinkFiltros(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//a[contains(text(),'Filtros de permisos')]"));
            return element;
        }

        public IWebElement LinkOpcionesCaptura(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//a[contains(text(),'Opciones de forma de captura')]"));
            return element;
        }

        public IWebElement LinkConfiguracionSerie(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//a[contains(text(),'Configuración de serie y folio')]"));
            return element;
        }

        public IWebElement LinkTimbre(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.LinkText("Timbre"));
            return element;
        }
        public IWebElement LinkAutoemision(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.LinkText("Configurar auto emisión"));
            return element;
        }

        public IWebElement LinkCFDIRelacionados(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.LinkText("CFDI Relacionados"));
            return element;
        }

        public IWebElement LinkEstadoComprobante(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.LinkText("Estado de un Comprobante"));
            return element;
        }

        public IWebElement LinkAceptacionRechazo(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.LinkText("Aceptación y rechazo"));
            return element;
        }

        public IWebElement LinkBitacora(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//a[contains(text(),'Bitácora')]"));
            return element;
        }

        public IWebElement LinkCFDI(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//a[@class='MenuBarItemSubmenu'][contains(text(),'CFDI 3.3')]"));
            return element;
        }

        public IWebElement LinkRetenciones(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//a[contains(text(),'Retenciones')]"));
            return element;
        }

        public IWebElement LinkPSECFDI(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//a[contains(text(),'PSECFDI 3.3')]"));
            return element;
        }
        // <a href = "/portal/Emision/SectorPrimario" > PSECFDI 3.3</a>
        //*[@id="MenuBar"]/li[3]/ul/li[1]/ul/li[1]/a
        public IWebElement LiCFDI3(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id='MenuBar']/li[3]/ul/li[1]/ul/li[1]/a"));
            return element;
        }

        public IWebElement LiFacturaGlobal(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//a[contains(text(),'CFDI 3.3 - Factura global')]"));
            return element;
        }
        public IWebElement LiRecepcionPagos(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//a[contains(text(),'CFDI 3.3 - Recepción de pagos')]"));
            return element;
        }

        public IWebElement LiNomina(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//a[contains(text(),'CFDI 3.3 - Nómina')]"));
            return element;
        }

        public IWebElement LiINE(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//a[contains(text(),'CFDI 3.3 - INE')]"));
            return element;
        }

        public IWebElement LiECC12(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//a[contains(text(),'CFDI 3.3 - ECC12')]"));
            return element;
        }

        public IWebElement LiComercio(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//a[contains(text(),'CFDI 3.3 - Comercio exterior')]"));
            return element;
        }

        public IWebElement LiHidrocarburos(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//a[contains(text(),'CFDI 3.3 - Gastos de Hidrocarburos')]"));
            return element;
        }

        public IWebElement LiMonitorEmision(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath(" //span[@id='monitorai']//a[contains(text(),'Emisión')]"));
            return element;
        }

        public IWebElement LiCFDI(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id='MenuBar']/li[5]/ul/li[1]/a"));
            return element;
        }

        public IWebElement LiPSECFDIBusquedas(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id='MenuBar']/li[5]/ul/li[2]/a"));
            return element;
        }

        public IWebElement LiRetencionesBusquedas(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id='MenuBar']/li[5]/ul/li[3]/a"));
            return element;
        }

        public IWebElement LiAutoEmisionBusquedas(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id='MenuBar']/li[5]/ul/li[4]/a"));
            return element;
        }

        public IWebElement LiPSECFDI(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//a[contains(text(),'PSECFDI')]"));
            return element;
        }

        public IWebElement LiRetenciones(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//a[contains(text(),'Retenciones')]"));
            return element;
        }

        public IWebElement LiAutoEmision(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//a[contains(text(),'Auto Emision')]"));
            return element;
        }

        public IWebElement LogoInicio(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("headerBarLogo"));
            return element;
        }
    }
}
