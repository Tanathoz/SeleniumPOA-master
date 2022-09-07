using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumPractice.PageObjects;
//using SeleniumExtras.WaitHelpers;
using SeleniumPractice.Helpers;
using SeleniumPractice.Entities;
using SeleniumExtras.WaitHelpers;

namespace SeleniumPractice.Flujos
{
    public class FLEmitir
    {
        POHome elemMenu = new POHome();
        POEmitir elemEmitir = new POEmitir();
        private bool resultado = false;

        public void navegarEmitir(IWebDriver driver)
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            ElementsMethods.HoverElement(driver, elemMenu.LogoInicio(driver));

            ElementsMethods.HoverElement(driver, elemMenu.MenuEmitir(driver));

            Thread.Sleep(1000);
            ElementsMethods.HoverElement(driver, elemMenu.LinkCFDI(driver));
            Thread.Sleep(1000);
            elemMenu.LiCFDI3(driver).Click();
            Thread.Sleep(1000);
            if (elemEmitir.BtnSeleccionaPlantilla(driver).Displayed)
                resultado = true;
            else
                resultado = false;
        }

        public void emitirCFDI(IWebDriver driver, EntComprobante misComprobantes)
        {
            try
            {
                if (elemEmitir.BtnSaltar(driver).Displayed)
                {
                    elemEmitir.BtnSaltar(driver).Click();
                    Thread.Sleep(1000);
                }

                if (elemEmitir.ModalInformacion(driver).Displayed)
                {
                    elemEmitir.BtnModalCancelar(driver).Click();
                    Thread.Sleep(1000);
                }
            }
            catch (Exception e)
            {

            }


            datosEmisorExc(driver, misComprobantes);
            datosComprobante(driver, misComprobantes);
            ElementsMethods.ScrollModalWindow(elemEmitir.DivDatosComprobante(driver), driver);
            Thread.Sleep(1000);
            datosReceptor(driver, misComprobantes.ReceptorDatos);
            ElementsMethods.ScrollModalWindow(elemEmitir.DivReceptor(driver), driver);
            Thread.Sleep(1000);
            if (misComprobantes.TipoDocumento.Equals("8"))
                datosConceptoCartaPorte(driver, misComprobantes.ConceptoDatos);
            else
                datosConcepto(driver, misComprobantes.ConceptoDatos);

            ElementsMethods.ScrollDown(driver);
            elemEmitir.BtnEmitir(driver).Click();
            new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(ExpectedConditions.ElementToBeClickable(elemEmitir.BtnAceptarResultado(driver)));

            if (elemEmitir.MensajeExitoComprobante(driver).Displayed)
            {
                resultado = true;
                Thread.Sleep(1000);
                // elemEmitir.BtnAceptarResultado(driver).Click();
                elemEmitir.BtnNuevaCaptura(driver).Click();
            }
            else
            {
                resultado = false;
            }
            // elemEmitir.DivEmisor(driver).Click();
        }


        public void navegarEmitirFactura(IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            ElementsMethods.HoverElement(driver, elemMenu.LogoInicio(driver));
            ElementsMethods.HoverElement(driver, elemMenu.MenuEmitir(driver));
            Thread.Sleep(1000);
            ElementsMethods.HoverElement(driver, elemMenu.LinkCFDI(driver));
            Thread.Sleep(1000);
            elemMenu.LiFacturaGlobal(driver).Click();
            Thread.Sleep(1000);
            if (elemEmitir.BtnSeleccionaPlantilla(driver).Displayed)
                resultado = true;
            else
                resultado = false;
        }


        public void emitirFacturaGlobal(IWebDriver driver, EntComprobante misComprobantes)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            if (elemEmitir.BtnSaltar(driver).Displayed)
            {
                elemEmitir.BtnSaltar(driver).Click();
                Thread.Sleep(1000);
            }

            if (elemEmitir.ModalInformacion(driver).Displayed)
            {
                elemEmitir.BtnModalCancelar(driver).Click();
                Thread.Sleep(1000);
            }
            datosEmisorExc(driver, misComprobantes);
            datosComprobanteFactura(driver, misComprobantes);
            ElementsMethods.ScrollModalWindow(elemEmitir.DivCFDIRelacionado(driver), driver);
            Thread.Sleep(1000);
            datosConceptoFactura(driver, misComprobantes.ConceptoDatos);

            ElementsMethods.ScrollDown(driver);
            elemEmitir.BtnEmitir(driver).Click();
            Thread.Sleep(1000);
            if (elemEmitir.MensajeExitoComprobante(driver).Displayed)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }
        }


        public void navegarEmitirRecepcion(IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            ElementsMethods.HoverElement(driver, elemMenu.LogoInicio(driver));
            ElementsMethods.HoverElement(driver, elemMenu.MenuEmitir(driver));
            Thread.Sleep(1000);
            ElementsMethods.HoverElement(driver, elemMenu.LinkCFDI(driver));
            //            elemMenu.LinkEmisionContratos(driver).Click();
            Thread.Sleep(1000);
            elemMenu.LiRecepcionPagos(driver).Click();
            Thread.Sleep(1000);
            if (elemEmitir.BtnSeleccionaPlantilla(driver).Displayed)
                resultado = true;
            else
                resultado = false;
        }

        public void emitirRecepcionPago(IWebDriver driver, EntComprobante misComprobantes)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            if (elemEmitir.ModalInformacion(driver).Displayed)
            {
                elemEmitir.BtnModalCancelar(driver).Click();
                Thread.Sleep(1000);
            }
            datosEmisorExc(driver, misComprobantes);
            datosComprobanteRecepcion(driver, misComprobantes);
            ElementsMethods.ScrollModalWindow(elemEmitir.DivCFDIRelacionado(driver), driver);
            datosReceptorRecepcionPago(driver, misComprobantes.ReceptorDatos);
            ElementsMethods.ScrollModalWindow(elemEmitir.DivReceptor(driver), driver);
            Thread.Sleep(750);
            datosComplementoRecepcion(driver, misComprobantes.ComplementoPago);
            ElementsMethods.ScrollDown(driver);
            Thread.Sleep(750);
            elemEmitir.BtnEmitir(driver).Click();
            //Thread.Sleep(1500);
            var btn = (new WebDriverWait(driver, TimeSpan.FromSeconds(25)).Until(ExpectedConditions.ElementToBeClickable(elemEmitir.BtnAceptarResultado(driver))));
            if (elemEmitir.MensajeExitoComprobante(driver).Displayed)
            {
                resultado = true;
                elemEmitir.BtnNuevaCaptura(driver).Click();
            }
            else
            {
                resultado = false;
            }
        }


        public void navegarEmitirNomina(IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            ElementsMethods.HoverElement(driver, elemMenu.LogoInicio(driver));
            ElementsMethods.HoverElement(driver, elemMenu.MenuEmitir(driver));
            Thread.Sleep(1000);
            ElementsMethods.HoverElement(driver, elemMenu.LinkCFDI(driver));
            Thread.Sleep(1000);
            elemMenu.LiNomina(driver).Click();
            Thread.Sleep(1000);
            if (elemEmitir.BtnSeleccionaPlantilla(driver).Displayed)
                resultado = true;
            else
                resultado = false;
        }

        public void emitirNomina(IWebDriver driver, EntComprobante misComprobantes)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            if (elemEmitir.ModalInformacion(driver).Displayed)
            {
                elemEmitir.BtnModalCancelar(driver).Click();
                Thread.Sleep(1000);
            }
            datosEmisorExc(driver, misComprobantes);
            datosComprobanteRecepcion(driver, misComprobantes);
            ElementsMethods.ScrollModalWindow(elemEmitir.DivCFDIRelacionado(driver), driver);
            datosReceptorRecepcionPago(driver, misComprobantes.ReceptorDatos);
            ElementsMethods.ScrollModalWindow(elemEmitir.DivReceptor(driver), driver);
            Thread.Sleep(1000);
            datosNomina(driver, misComprobantes.Nomina);
            ElementsMethods.ScrollDown(driver);
            elemEmitir.BtnEmitir(driver).Click();
            new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(ExpectedConditions.ElementToBeClickable(elemEmitir.BtnAceptarResultado(driver)));

            if (elemEmitir.MensajeExitoComprobante(driver).Displayed)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }

        }

        public void navegarEmitirINE(IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            ElementsMethods.HoverElement(driver, elemMenu.LogoInicio(driver));
            ElementsMethods.HoverElement(driver, elemMenu.MenuEmitir(driver));
            Thread.Sleep(1000);
            ElementsMethods.HoverElement(driver, elemMenu.LinkCFDI(driver));
            Thread.Sleep(1000);
            elemMenu.LiINE(driver).Click();
            Thread.Sleep(1000);
            if (elemEmitir.BtnSeleccionaPlantilla(driver).Displayed)
                resultado = true;
            else
                resultado = false;
        }

        public void emitirINE(IWebDriver driver, EntComprobante misComprobantes)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            if (elemEmitir.ModalInformacion(driver).Displayed)
            {
                elemEmitir.BtnModalCancelar(driver).Click();
                Thread.Sleep(1000);
            }
            datosEmisorExc(driver, misComprobantes);
            datosComprobante(driver, misComprobantes);
            ElementsMethods.ScrollModalWindow(elemEmitir.DivCFDIRelacionado(driver), driver);
            Thread.Sleep(1000);
            datosReceptor(driver, misComprobantes.ReceptorDatos);
            ElementsMethods.ScrollModalWindow(elemEmitir.DivReceptor(driver), driver);
            datosConcepto(driver, misComprobantes.ConceptoDatos);
            ElementsMethods.ScrollModalWindow(elemEmitir.DivImpuestos(driver), driver);
            datosINE(driver);
            ElementsMethods.ScrollDown(driver);
            elemEmitir.BtnEmitir(driver).Click();
            new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(ExpectedConditions.ElementToBeClickable(elemEmitir.BtnAceptarResultado(driver)));

            if (elemEmitir.MensajeExitoComprobante(driver).Displayed)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }

        }

        public void navegarEmitirECC12(IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            ElementsMethods.HoverElement(driver, elemMenu.LogoInicio(driver));
            ElementsMethods.HoverElement(driver, elemMenu.MenuEmitir(driver));
            Thread.Sleep(1000);
            ElementsMethods.HoverElement(driver, elemMenu.LinkCFDI(driver));
            Thread.Sleep(1000);
            elemMenu.LiECC12(driver).Click();
            Thread.Sleep(1000);
            if (elemEmitir.BtnSeleccionaPlantilla(driver).Displayed)
                resultado = true;
            else
                resultado = false;
        }

        public void emitirECC12(IWebDriver driver, EntComprobante misComprobantes)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            if (elemEmitir.ModalInformacion(driver).Displayed)
            {
                elemEmitir.BtnModalCancelar(driver).Click();
                Thread.Sleep(1000);
            }
            datosEmisorExc(driver, misComprobantes);
            datosComprobante(driver, misComprobantes);

            ElementsMethods.ScrollModalWindow(elemEmitir.DivCFDIRelacionado(driver), driver);
            Thread.Sleep(1000);
            datosReceptor(driver, misComprobantes.ReceptorDatos);
            datosConcepto(driver, misComprobantes.ConceptoDatos);
            ElementsMethods.ScrollModalWindow(elemEmitir.DivImpuestos(driver), driver);
            datosComplementoCombustible(driver, misComprobantes.Combustible);
            ElementsMethods.ScrollDown(driver);
            elemEmitir.BtnEmitir(driver).Click();
            new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(ExpectedConditions.ElementToBeClickable(elemEmitir.BtnAceptarResultado(driver)));
            if (elemEmitir.MensajeExitoComprobante(driver).Displayed)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }

        }


        public void navegarEmitirComercio(IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            ElementsMethods.HoverElement(driver, elemMenu.LogoInicio(driver));
            ElementsMethods.HoverElement(driver, elemMenu.MenuEmitir(driver));
            Thread.Sleep(1000);
            ElementsMethods.HoverElement(driver, elemMenu.LinkCFDI(driver));
            Thread.Sleep(1000);
            elemMenu.LiComercio(driver).Click();
            Thread.Sleep(1000);
            if (elemEmitir.BtnSeleccionaPlantilla(driver).Displayed)
                resultado = true;
            else
                resultado = false;
        }

        public void emitirComercioExterior(IWebDriver driver, EntComprobante misComprobantes)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            if (elemEmitir.ModalInformacion(driver).Displayed)
            {
                elemEmitir.BtnModalCancelar(driver).Click();
                Thread.Sleep(1000);
            }

            datosEmisorExc(driver, misComprobantes);
            datosComprobante(driver, misComprobantes);
            ElementsMethods.ScrollModalWindow(elemEmitir.DivDatosCFDIRelacionados(driver), driver);
            Thread.Sleep(500);
            datosReceptorComercio(driver, misComprobantes.ReceptorDatos);
            ElementsMethods.ScrollModalWindow(elemEmitir.DivReceptor(driver), driver);
            Thread.Sleep(1000);
            datosConceptoComercio(driver, misComprobantes.ConceptoDatos);
            ElementsMethods.ScrollModalWindow(elemEmitir.DivImpuestos(driver), driver);
            datosComplementoComercioExterior(driver, misComprobantes.ComercioExt);
            ElementsMethods.ScrollDown(driver);
            Thread.Sleep(1000);
            elemEmitir.BtnEmitir(driver).Click();
            new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(ExpectedConditions.ElementToBeClickable(elemEmitir.BtnAceptarResultado(driver)));
            if (elemEmitir.MensajeExitoComprobante(driver).Displayed)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }

        }

        public void navegarEmitirHidrocarburos(IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            ElementsMethods.HoverElement(driver, elemMenu.LogoInicio(driver));
            ElementsMethods.HoverElement(driver, elemMenu.MenuEmitir(driver));
            Thread.Sleep(1000);
            ElementsMethods.HoverElement(driver, elemMenu.LinkCFDI(driver));
            Thread.Sleep(1000);
            elemMenu.LiHidrocarburos(driver).Click();
            Thread.Sleep(1000);
            if (elemEmitir.BtnSeleccionaPlantilla(driver).Displayed)
                resultado = true;
            else
                resultado = false;
        }

        public void emitirHidrocarburos(IWebDriver driver, EntComprobante misComprobantes)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            if (elemEmitir.ModalInformacion(driver).Displayed)
            {
                elemEmitir.BtnModalCancelar(driver).Click();
                Thread.Sleep(1000);
            }
            datosEmisorExc(driver, misComprobantes);
            datosComprobante(driver, misComprobantes);
            Thread.Sleep(500);
            ElementsMethods.ScrollModalWindow(elemEmitir.DivDatosComprobante(driver), driver);
            datosReceptor(driver, misComprobantes.ReceptorDatos);
            ElementsMethods.ScrollModalWindow(elemEmitir.DivReceptor(driver), driver);
            Thread.Sleep(1000);
            datosConceptoComercio(driver, misComprobantes.ConceptoDatos);
            ElementsMethods.ScrollModalWindow(elemEmitir.DivImpuestos(driver), driver);
            datosHidrocarburos(driver, misComprobantes.Hidrocarburos);
            ElementsMethods.ScrollDown(driver);
            elemEmitir.BtnEmitir(driver).Click();
            new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(ExpectedConditions.ElementToBeClickable(elemEmitir.BtnAceptarResultado(driver)));
            if (elemEmitir.MensajeExitoComprobante(driver).Displayed)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }

        }


        public void datosEmisor(IWebDriver driver)
        {
            elemEmitir.DivEmisor(driver).Click();
            // elemEmitir.SelectRFC(driver).Click();
            elemEmitir.SeleccionarRFC(elemEmitir.SelectRFC(driver)).SelectByIndex(0);
            Thread.Sleep(500);
            elemEmitir.BtnAceptarDatosEmisor(driver).Click();
            Thread.Sleep(200);
        }

        public void datosEmisorExc(IWebDriver driver, EntComprobante comprobante)
        {
            Thread.Sleep(1000);
            elemEmitir.DivEmisor(driver).Click();
            // elemEmitir.SelectRFC(driver).Click();
            Thread.Sleep(1000);
            elemEmitir.SeleccionarRFC(elemEmitir.SelectRFC(driver)).SelectByText(comprobante.EmisorDatos.RFC);
            Thread.Sleep(500);
            elemEmitir.BtnAceptarDatosEmisor(driver).Click();
            Thread.Sleep(500);
        }



        public void datosComprobante(IWebDriver driver, EntComprobante comprobante)
        {
            elemEmitir.DivDatosComprobante(driver).Click();
            elemEmitir.SelectTipoDocumento(driver).Click();
            elemEmitir.SeleccionarTipoDocumento(elemEmitir.SelectTipoDocumento(driver)).SelectByValue(comprobante.TipoDocumento);
            elemEmitir.InputExpedicion(driver).SendKeys(comprobante.Expedicion);
            elemEmitir.InputMoneda(driver).SendKeys(comprobante.Moneda);
            elemEmitir.ListaMoneda(driver).Click();
            elemEmitir.InputSerie(driver).SendKeys(comprobante.Serie);
            if (!comprobante.TipoDocumento.Equals("8"))
            {
                elemEmitir.InputFormaDePago(driver).SendKeys(comprobante.FormaPago);
                elemEmitir.ListaFormaPago(driver, comprobante.FormaPago).Click();
                elemEmitir.InputMetodoDePago(driver).SendKeys(comprobante.MetodoPago);
                elemEmitir.ListaMetodoPago(driver, comprobante.MetodoPago).Click();
            }

            Thread.Sleep(500);
            elemEmitir.BtnAceptarComprobante(driver).Click();
            Thread.Sleep(500);
        }


        public void datosComprobanteFactura(IWebDriver driver, EntComprobante comprobante)
        {
            elemEmitir.DivDatosComprobante(driver).Click();
            elemEmitir.SelectTipoDocumento(driver).Click();
            elemEmitir.SeleccionarTipoDocumento(elemEmitir.SelectTipoDocumento(driver)).SelectByValue(comprobante.TipoDocumento);
            elemEmitir.InputExpedicion(driver).SendKeys(comprobante.Expedicion);
            elemEmitir.InputMoneda(driver).SendKeys(comprobante.Moneda);
            elemEmitir.ListaMoneda(driver).Click();
            elemEmitir.InputSerie(driver).SendKeys(comprobante.Serie);
            elemEmitir.InputFormaDePago(driver).SendKeys(comprobante.FormaPago);
            elemEmitir.ListaFormaPago(driver, comprobante.FormaPago).Click();
            elemEmitir.BtnAceptarComprobante(driver).Click();
            Thread.Sleep(1000);
        }

        public void datosComprobanteRecepcion(IWebDriver driver, EntComprobante comprobante)
        {
            elemEmitir.DivDatosComprobante(driver).Click();
            elemEmitir.SelectTipoDocumento(driver).Click();
            elemEmitir.SeleccionarTipoDocumento(elemEmitir.SelectTipoDocumento(driver)).SelectByIndex(0);
            elemEmitir.InputExpedicion(driver).SendKeys(comprobante.Expedicion);
            elemEmitir.InputSerie(driver).SendKeys(comprobante.Serie);
            elemEmitir.BtnAceptarComprobanteRecepcion(driver).Click();
            Thread.Sleep(1000);
        }


        //public void datosReceptor(IWebDriver driver)
        //{
        //    elemEmitir.DivReceptor(driver).Click();
        //    elemEmitir.InputReceptorRFC(driver).SendKeys("CACX7605101P8");
        //    elemEmitir.SelectUsoCFDI(driver).Click();
        //    elemEmitir.SeleccionarUsoCFDI(elemEmitir.SelectUsoCFDI(driver)).SelectByIndex(13);
        //    elemEmitir.InputNombreDatosReceptor(driver).SendKeys("Xochilt Casas");
        //    elemEmitir.BtnAceptarReceptor(driver).Click();
        //    Thread.Sleep(1000);
        //}

        public void datosReceptor(IWebDriver driver, Receptor receptor)
        {
            elemEmitir.DivReceptor(driver).Click();
            elemEmitir.InputReceptorRFC(driver).SendKeys(receptor.RFCReceptor);
            elemEmitir.SelectUsoCFDI(driver).Click();
            elemEmitir.SeleccionarUsoCFDI(elemEmitir.SelectUsoCFDI(driver)).SelectByValue(receptor.UsoCFDI);
            elemEmitir.InputNombreDatosReceptor(driver).SendKeys(receptor.Nombre);
            elemEmitir.BtnAceptarReceptor(driver).Click();
            Thread.Sleep(1000);
        }

        public void datosReceptorRecepcionPago(IWebDriver driver, Receptor receptor)
        {
            elemEmitir.DivReceptor(driver).Click();
            elemEmitir.InputReceptorRFC(driver).SendKeys(receptor.RFCReceptor);
            elemEmitir.BtnAceptarReceptor(driver).Click();
            Thread.Sleep(1000);
        }

        public void datosReceptorComercio(IWebDriver driver, Receptor receptor)
        {
            elemEmitir.DivReceptor(driver).Click();
            elemEmitir.InputReceptorRFC(driver).SendKeys(receptor.RFCReceptor);
            elemEmitir.SelectUsoCFDI(driver).Click();
            elemEmitir.SeleccionarUsoCFDI(elemEmitir.SelectUsoCFDI(driver)).SelectByValue(receptor.UsoCFDI);
            elemEmitir.InputNombreDatosReceptor(driver).SendKeys(receptor.Nombre);
            elemEmitir.InputResidenciaFiscal(driver).SendKeys(receptor.ResidenciaFiscal);
            elemEmitir.ListaComercioExteriorPaisReceptor(driver).Click();
            elemEmitir.InputIDTributario(driver).SendKeys(receptor.IDTributario);
            elemEmitir.BtnAceptarReceptor(driver).Click();
            Thread.Sleep(1000);
        }
        //public void datosConcepto(IWebDriver driver, Concepto concepto)
        //{
        //    elemEmitir.BtnAgregarConcepto(driver).Click();
        //    elemEmitir.InputClaveProducto(driver).SendKeys(concepto.ClaveProducto);
        //    elemEmitir.ListaClaveProducto(driver).Click();
        //    elemEmitir.InputUnidad(driver).SendKeys(concepto.Unidad);
        //    elemEmitir.InputClaveUnidad(driver).SendKeys(concepto.ClaveUnidad);
        //    elemEmitir.ListaClaveUnidad(driver).Click();
        //    elemEmitir.InputDescripcion(driver).SendKeys(concepto.Descripcion);
        //    elemEmitir.InputCantidad(driver).SendKeys(concepto.Cantidad);
        //    elemEmitir.InputValorUnitario(driver).SendKeys(concepto.ValorUnitario);
        //    ElementsMethods.ScrollModalWindow(elemEmitir.BtnImpuestoTraslado(driver), driver);
        //    elemEmitir.InputDescuento(driver).SendKeys("120");
        //    datosImpuestoTrasladado(driver);
        //    datosImpuestoRetenido(driver);
        //    elemEmitir.BtnAceptarConcepto(driver).Click();
        //    Thread.Sleep(1000);
        //}


        public void datosConcepto(IWebDriver driver, Concepto concepto)
        {
            elemEmitir.BtnAgregarConcepto(driver).Click();
            elemEmitir.InputClaveProducto(driver).SendKeys(concepto.ClaveProducto);
            elemEmitir.ListaClaveProducto(driver).Click();
            elemEmitir.InputUnidad(driver).SendKeys(concepto.Unidad);
            elemEmitir.InputClaveUnidad(driver).SendKeys(concepto.ClaveUnidad);
            elemEmitir.ListaClaveUnidad(driver).Click();
            elemEmitir.InputDescripcion(driver).SendKeys(concepto.Descripcion);
            elemEmitir.InputCantidad(driver).SendKeys(concepto.Cantidad);
            elemEmitir.InputValorUnitario(driver).SendKeys(concepto.ValorUnitario);
            ElementsMethods.ScrollModalWindow(elemEmitir.BtnImpuestoTraslado(driver), driver);
            elemEmitir.InputDescuento(driver).SendKeys(concepto.Descuento);
            datosImpuestoTrasladado(driver);
            datosImpuestoRetenido(driver);
            elemEmitir.BtnAceptarConcepto(driver).Click();
            Thread.Sleep(1000);
        }

        public void datosConceptoCartaPorte(IWebDriver driver, Concepto concepto)
        {
            elemEmitir.BtnAgregarConcepto(driver).Click();
            elemEmitir.InputClaveProducto(driver).SendKeys(concepto.ClaveProducto);
            elemEmitir.ListaClaveProducto(driver).Click();
            elemEmitir.InputUnidad(driver).SendKeys(concepto.Unidad);
            elemEmitir.InputClaveUnidad(driver).SendKeys(concepto.ClaveUnidad);
            elemEmitir.ListaClaveUnidad(driver).Click();
            elemEmitir.InputDescripcion(driver).SendKeys(concepto.Descripcion);
            elemEmitir.InputCantidad(driver).SendKeys(concepto.Cantidad);
            elemEmitir.InputValorUnitario(driver).SendKeys(concepto.ValorUnitario);
            ElementsMethods.ScrollModalWindow(elemEmitir.BtnImpuestoTraslado(driver), driver);

            elemEmitir.BtnAceptarConcepto(driver).Click();
            Thread.Sleep(1000);
        }

        public void datosConceptoFactura(IWebDriver driver, Concepto concepto)
        {
            elemEmitir.BtnAgregarConcepto(driver).Click();
            elemEmitir.InputValorUnitario(driver).SendKeys(concepto.ValorUnitario);
            elemEmitir.InputDescuento(driver).SendKeys(concepto.Descuento);
            datosImpuestoTrasladado(driver);
            elemEmitir.BtnAceptarConcepto(driver).Click();
            Thread.Sleep(1000);
        }
        //Aqui queda por que este concepto tiene más campos que se tendrian que agregar 
        public void datosConceptoComercio(IWebDriver driver, Concepto concepto)
        {
            elemEmitir.BtnAgregarConcepto(driver).Click();
            elemEmitir.InputClaveProducto(driver).SendKeys(concepto.ClaveProducto);
            elemEmitir.ListaClaveProducto(driver).Click();
            elemEmitir.InputNumIdentificacion(driver).SendKeys(concepto.NumIdentificacion);
            elemEmitir.InputUnidad(driver).SendKeys(concepto.Unidad);
            elemEmitir.InputClaveUnidad(driver).SendKeys(concepto.ClaveUnidad);
            elemEmitir.ListaClaveUnidad(driver).Click();
            elemEmitir.InputDescripcion(driver).SendKeys(concepto.Descripcion);
            elemEmitir.InputCantidad(driver).SendKeys(concepto.Cantidad);
            elemEmitir.InputValorUnitario(driver).SendKeys(concepto.ValorUnitario);
            ElementsMethods.ScrollModalWindow(elemEmitir.BtnImpuestoTraslado(driver), driver);
            elemEmitir.InputDescuento(driver).SendKeys(concepto.Descuento);
            datosImpuestoTrasladado(driver);
            elemEmitir.BtnAceptarConcepto(driver).Click();
            Thread.Sleep(1000);
        }

        public void datosComplementoRecepcion(IWebDriver driver, ComplementoPago complemento)
        {
            elemEmitir.BtnAgregarPago(driver).Click();
            Thread.Sleep(500);
            elemEmitir.SpanCalendarioComplemento(driver).Click();
            Thread.Sleep(1000);

            ElementsMethods.seleccionarFecha(elemEmitir.MesCalendario(driver), elemEmitir.AnioCalendario(driver), driver, complemento.FechaPago);
            // ElementsMethods.leerCalendario(driver,"17");          
            elemEmitir.InputFormaPagoComplemento(driver).SendKeys(complemento.FormaPago);
            elemEmitir.ListaFormaMetodoPago(driver).Click();
            elemEmitir.InputFormaPagoMoneda(driver).SendKeys("MXN");
            elemEmitir.ListaMonedaPago(driver).Click();
            elemEmitir.InputMontoFormaPago(driver).SendKeys(complemento.Monto);
            datosDocumentosRelacionados(driver, complemento);
            Thread.Sleep(1000);
            elemEmitir.BtnAceptarFormaPago(driver).Click();
        }

        public void datosDocumentosRelacionados(IWebDriver driver, ComplementoPago complemento)
        {
            elemEmitir.PestaniaDocumentoRelacionados(driver).Click();
            elemEmitir.BtnAgregarDocumento(driver).Click();
            elemEmitir.InputIDDocumento(driver).SendKeys(complemento.IdDocumento);
            elemEmitir.InputDocumentoMoneda(driver).SendKeys("MXN");
            Thread.Sleep(500);
            elemEmitir.ListaDocumentoMoneda(driver).Click();
            elemEmitir.InputDocumentoSerie(driver).SendKeys("Test");
            ElementsMethods.ScrollModalWindow(elemEmitir.InputDocumentoSaldoInsoluto(driver), driver);
            Thread.Sleep(500);
            elemEmitir.InputDocumentoParcialidad(driver).SendKeys(complemento.Parcialidad);
            elemEmitir.InputDocumentoSaldoAnt(driver).SendKeys(complemento.SaldoAnterior);
            elemEmitir.InputDocumentoPagado(driver).SendKeys(complemento.ImportePagado);
            elemEmitir.InputDocumentoSaldoInsoluto(driver).SendKeys(complemento.ImporteInsoluto);
            elemEmitir.BtnAddDocumentoRelacionado(driver).Click();
        }

        public void datosNomina(IWebDriver driver, Nomina nomina)
        {
            elemEmitir.BtnAddNomina(driver).Click();
            Thread.Sleep(500);
            elemEmitir.SeleccionarTipoNomina(elemEmitir.SelectTipoNomina(driver)).SelectByIndex(1);
            elemEmitir.SpanCalendarioNominaFechaPago(driver).Click();
            Thread.Sleep(500);
            ElementsMethods.seleccionarFecha(elemEmitir.MesCalendario(driver), elemEmitir.AnioCalendario(driver), driver, nomina.FechaPago);
            elemEmitir.SpanCalendarioNominaFechaInicio(driver).Click();
            Thread.Sleep(500);
            ElementsMethods.seleccionarFecha(elemEmitir.MesCalendario(driver), elemEmitir.AnioCalendario(driver), driver, nomina.FechaInicio);
            elemEmitir.SpanCalendarioNominaFechaFinal(driver).Click();
            Thread.Sleep(500);
            ElementsMethods.seleccionarFecha(elemEmitir.MesCalendario(driver), elemEmitir.AnioCalendario(driver), driver, nomina.FechaFinal);

            elemEmitir.InputNominaNumDias(driver).SendKeys(nomina.NumDias);
            datosNominaEmisor(driver, nomina);
            datosNominaReceptor(driver, nomina);
            datosSubcontrataciones(driver, nomina);
            datosPercepciones(driver, nomina);
            elemEmitir.BtnAceptarNomina(driver).Click();
        }

        public void datosNominaEmisor(IWebDriver driver, Nomina nomina)
        {
            elemEmitir.InputNominaRegistro(driver).SendKeys(nomina.Registro);
            // elemEmitir.InputNominaOrigenRecurso(driver).SendKeys("IF");
            // elemEmitir.ListaOrigenRecurso(driver).Click();
        }

        public void datosNominaReceptor(IWebDriver driver, Nomina nomina)
        {
            elemEmitir.InputNominaCURP(driver).SendKeys(nomina.CURP);
            elemEmitir.InputSeguroSocial(driver).SendKeys(nomina.SeguroSocial);
            ElementsMethods.ScrollModalWindow(elemEmitir.InputAntiguedad(driver), driver);
            Thread.Sleep(500);
            elemEmitir.SpanCalendarioNominaFechaInicioLaboral(driver).Click();
            Thread.Sleep(500);
            ElementsMethods.seleccionarFecha(elemEmitir.MesCalendario(driver), elemEmitir.AnioCalendario(driver), driver, nomina.FechaContrato);
            elemEmitir.InputAntiguedad(driver).SendKeys(nomina.Antiguedad);
            elemEmitir.InputTipoContrato(driver).SendKeys(nomina.TipoContrato);
            elemEmitir.ListaTipoContrato(driver).Click();
            elemEmitir.SeleccionarSindicalizado(elemEmitir.SelectSindicalizado(driver)).SelectByIndex(1);
            elemEmitir.InputNominaRegimen(driver).SendKeys(nomina.Regimen);
            elemEmitir.ListaNominaRegimen(driver).Click();
            elemEmitir.InputNumeroEmpleado(driver).SendKeys(nomina.NumEmpleado);
            elemEmitir.InputDepartamento(driver).SendKeys(nomina.Departamento);
            elemEmitir.InputRiesgoPuesto(driver).SendKeys(nomina.RiesgoPuesto);
            elemEmitir.ListaRiesgoPuesto(driver).Click();
            elemEmitir.InputPeriodoPago(driver).SendKeys(nomina.PeriodoPago);
            elemEmitir.ListaPeriodoPago(driver).Click();
            ElementsMethods.ScrollModalWindow(elemEmitir.InputSalarioIntegrado(driver), driver);
            elemEmitir.InputSalarioIntegrado(driver).SendKeys(nomina.Salario);
            elemEmitir.InputNominaEntidadFederativa(driver).SendKeys(nomina.Entidad);
            elemEmitir.ListaNominaEntidadFederativa(driver).Click();
        }

        public void datosSubcontrataciones(IWebDriver driver, Nomina nomina)
        {
            elemEmitir.BtnAddSubcontrataciones(driver).Click();
            elemEmitir.InputPorcentajeTiempo(driver).SendKeys(nomina.Porcentaje);
            elemEmitir.InputRFCLabora(driver).SendKeys(nomina.RFCLabora);
            elemEmitir.BtnAceptarSubcontrataciones(driver).Click();
            Thread.Sleep(500);
        }

        public void datosPercepciones(IWebDriver driver, Nomina nomina)
        {
            ElementsMethods.ScrollModalWindow(elemEmitir.BtnAddPercepcion(driver), driver);
            elemEmitir.BtnAddPercepcion(driver).Click();
            elemEmitir.InputTipoPercepcion(driver).SendKeys(nomina.Percepcion);
            Thread.Sleep(1000);
            // ElementsMethods.HoverElementAndClick(driver, elemEmitir.ListaTipoPercepcion(driver), elemEmitir.ListaTipoPercepcion(driver));
            elemEmitir.ListaTipoPercepcion(driver).Click();
            elemEmitir.InputPercepcionClave(driver).SendKeys(nomina.ClavePercepcion);
            elemEmitir.InputPercepcionConcepto(driver).SendKeys(nomina.Concepto);
            elemEmitir.InputPercepcionImporteGravado(driver).SendKeys(nomina.ImporteGravado);
            elemEmitir.InputPercepcionImporteExento(driver).SendKeys(nomina.ImporteExento);
            Thread.Sleep(500);
            elemEmitir.BtnAceptarPercepcion(driver).Click();
        }

        public void datosINE(IWebDriver driver)
        {
            elemEmitir.BtnAddINE(driver).Click();
            Thread.Sleep(1000);
            elemEmitir.SeleccionarTipoProceso(elemEmitir.SelectTipoProceso(driver)).SelectByIndex(0);
            elemEmitir.SeleccionarTipoComite(elemEmitir.SelectTipoComite(driver)).SelectByIndex(1);
            elemEmitir.BtnAceptarINE(driver).Click();
        }

        public void datosComplementoCombustible(IWebDriver driver, Combustible combustible)
        {
            elemEmitir.BtnAddComplementoCombustible(driver).Click();
            elemEmitir.InputNumeroCuenta(driver).SendKeys(combustible.NumeroCuenta);
            elemEmitir.BtnAddConceptoCombustible(driver).Click();
            elemEmitir.InputIdentificadorCombustible(driver).SendKeys(combustible.IdCombustible);
            elemEmitir.SpanCalendarioCombustibleFecha(driver).Click();
            Thread.Sleep(500);
            ElementsMethods.seleccionarFecha(elemEmitir.MesCalendario(driver), elemEmitir.AnioCalendario(driver), driver, combustible.CombustibleFecha);
            elemEmitir.InputRFCCombustible(driver).SendKeys(combustible.RFCCombustible);
            elemEmitir.InputClaveEstacio(driver).SendKeys(combustible.ClaveEstacion);
            elemEmitir.InputCantidadCombustible(driver).SendKeys(combustible.Cantidad);
            elemEmitir.SeleccionarTipoCombustible(elemEmitir.SelectTipoCombustible(driver)).SelectByIndex(1);
            elemEmitir.InputNombreCombustible(driver).SendKeys(combustible.Nombre);
            elemEmitir.InputFolioCombustible(driver).SendKeys(combustible.Folio);
            elemEmitir.InputValorCombustible(driver).SendKeys(combustible.Valor);
            elemEmitir.InputImporteCombustible(driver).SendKeys(combustible.Importe);
            elemEmitir.BtnAddTrasladoCombustible(driver).Click();
            Thread.Sleep(500);
            elemEmitir.SeleccionarCombustibleImpuesto(elemEmitir.SelectCombustibleImpuesto(driver)).SelectByIndex(0);
            elemEmitir.InputCombustibleTasa(driver).SendKeys(combustible.Tasa);
            elemEmitir.InputTrasladadoImporte(driver).SendKeys(combustible.ImporteTraslado);
            elemEmitir.BtnAgregarTrasladoCombustible(driver).Click();
            Thread.Sleep(500);
            elemEmitir.BtnAceptarCombustibleConcepto(driver).Click();
            elemEmitir.BtnAceptarComplementoCombustible(driver).Click();
        }

        public void datosComplementoComercioExterior(IWebDriver driver, ComercioExterior comercio)
        {
            elemEmitir.BtnAddComplementoCombustible(driver).Click();
            Thread.Sleep(500);
            //  elemEmitir.SeleccionarMotivoTraslado(elemEmitir.SelectMotivoTraslado(driver)).SelectByIndex(2);
            elemEmitir.SeleccionarCertificadoOrigen(elemEmitir.SelectCertificadoOrigen(driver)).SelectByIndex(1);
            elemEmitir.SeleccionarIncortem(elemEmitir.SelectIncortem(driver)).SelectByIndex(1);
            elemEmitir.SeleccionarComercioSubdivision(elemEmitir.SelectComercioSubdivision(driver)).SelectByIndex(1);
            datosComercioEmisor(driver);
            datosComercioReceptor(driver);
            datosComercioMercancia(driver, comercio);
            elemEmitir.BtnAgregarComercioExterior(driver).Click();
        }

        public void datosComercioEmisor(IWebDriver driver)
        {
            ElementsMethods.ScrollModalWindow(elemEmitir.InputComercioCalle(driver), driver);
            elemEmitir.InputComercioCalle(driver).SendKeys("fantasia");
            elemEmitir.SeleccionarComercioEstado(elemEmitir.SelectComercioEstado(driver)).SelectByIndex(6);
            elemEmitir.SeleccionarComercioMunicipio(elemEmitir.SelectComercioMunicipio(driver)).SelectByIndex(14);
            elemEmitir.InputComercioCodigoPostal(driver).SendKeys("11520");
            Thread.Sleep(200);
            elemEmitir.SelectComercioLocalidad(driver).Click();
            elemEmitir.SeleccionarComercioLocalidad(elemEmitir.SelectComercioLocalidad(driver)).SelectByIndex(1);
            elemEmitir.SeleccionarComercioColonia(elemEmitir.SelectComercioColonia(driver)).SelectByIndex(1);

        }

        public void datosComercioReceptor(IWebDriver driver)
        {
            ElementsMethods.ScrollModalWindow(elemEmitir.InputComerciorReceptorCalle(driver), driver);
            elemEmitir.InputComerciorReceptorCalle(driver).SendKeys("Falsa");
            elemEmitir.InputComerciorPais(driver).SendKeys("Mex");
            Thread.Sleep(200);
            elemEmitir.ListaComercioPaisReceptor(driver).Click();
            elemEmitir.InputComerciorReceptorCodigoPostal(driver).SendKeys("04369");
            elemEmitir.SeleccionarComercioReceptorEstado(elemEmitir.SelectComercioReceptorEstado(driver)).SelectByIndex(6);
            elemEmitir.SeleccionarComercioReceptorMunicipio(elemEmitir.SelectComercioReceptorMunicipio(driver)).SelectByIndex(1);
            //elemEmitir.SelectComercioReceptorLocalidad(driver).Click();
            ElementsMethods.ScrollModalWindow(elemEmitir.SelectComercioReceptorLocalidad(driver), driver);
            elemEmitir.SeleccionarComercioReceptorLocalidad(elemEmitir.SelectComercioReceptorLocalidad(driver)).SelectByIndex(1);
            elemEmitir.SeleccionarComercioReceptorColonia(elemEmitir.SelectComercioReceptorColonia(driver)).SelectByIndex(1);
        }

        public void datosComercioMercancia(IWebDriver driver, ComercioExterior comercio)
        {
            ElementsMethods.ScrollModalWindow(elemEmitir.PestaniaAddComercioMercancias(driver), driver);
            //  elemEmitir.PestaniaAddComercioMercancias(driver).Click();
            elemEmitir.BtnAddComercioMercancias(driver).Click();
            elemEmitir.InputComerciorMercanciaNIdentificacion(driver).SendKeys(comercio.NumIdentificacion);
            elemEmitir.InputComerciorMercanciaFraccionArancel(driver).SendKeys(comercio.FraccionArancel);
            elemEmitir.ListaComerciorMercanciaFraccionArancel(driver).Click();
            elemEmitir.InputComerciorMercanciaCantidadAduana(driver).SendKeys(comercio.CantidadAduana);
            elemEmitir.InputComerciorMercanciaUnitarioAduana(driver).SendKeys(comercio.UnitarioAduana);
            elemEmitir.InputComerciorMercanciaValorDolares(driver).SendKeys(comercio.ValorDolares);
            elemEmitir.InputComerciorMercanciaUnitarioAduana(driver).Click();
            Thread.Sleep(500);
            elemEmitir.BtnAgregarMercancias(driver).Click();
        }

        public void datosHidrocarburos(IWebDriver driver, Hidrocarburos hidro)
        {
            elemEmitir.BtnAddComplementoCombustible(driver).Click();
            Thread.Sleep(500);
            elemEmitir.InputHidrocarburosNumContrato(driver).SendKeys(hidro.NumContrato);
            elemEmitir.PestiniaAgregarErogacion(driver).Click();
            elemEmitir.BtnAgregarErogacion(driver).Click();
            Thread.Sleep(500);
            elemEmitir.SeleccionarHidrocarburosErogaciones(elemEmitir.SelectHidrocarburosErogaciones(driver)).SelectByIndex(0);
            elemEmitir.InputHidrocarburosMonto(driver).SendKeys(hidro.Monto);
            elemEmitir.InputHidrocarburosPorcentaje(driver).SendKeys(hidro.Porcentaje);
            datosHidrocarburosDocumentos(driver, hidro);
            Thread.Sleep(500);
            elemEmitir.BtnAceptarErogacion(driver).Click();
            elemEmitir.BtnAceptarHidrocarburos(driver).Click();
        }

        public void datosHidrocarburosDocumentos(IWebDriver driver, Hidrocarburos hidro)
        {
            elemEmitir.PestiniaErogacionDocumentoRelacionado(driver).Click();
            elemEmitir.BtnAgregarDocumentoRelacionado(driver).Click();
            Thread.Sleep(500);
            elemEmitir.SeleccionarHidrocarburosErogacionesOrigen(elemEmitir.SelectHidrocarburosErogacionesOrigen(driver)).SelectByIndex(Int32.Parse(hidro.ErogacionOrigen));
            elemEmitir.InputHidrocarburosTotalErogacion(driver).SendKeys(hidro.Total);
            elemEmitir.SeleccionarHidrocarburosErogacionesMes(elemEmitir.SelectHidrocarburosErogacionesMes(driver)).SelectByIndex(Int32.Parse(hidro.ErogacionMes));
            //elemEmitir.InputHidrocarburosFolioFiscal(driver).SendKeys("1CE6B99E-4490-4E65-B9C5-DCD18B1E488A");
            elemEmitir.BtnAceptarDocumentoRelacionado(driver).Click();

        }

        public void datosImpuestoTrasladado(IWebDriver driver)
        {
            elemEmitir.BtnImpuestoTraslado(driver).Click();
            elemEmitir.SelectTipoFactor(driver).Click();
            elemEmitir.SeleccionarTipoFactor(elemEmitir.SelectTipoFactor(driver)).SelectByIndex(1);
            elemEmitir.SeleccionarTipoImpuesto(elemEmitir.SelectTipoImpuesto(driver)).SelectByIndex(1);
            elemEmitir.SeleccionarTasa(elemEmitir.SelectTipoTasa(driver)).SelectByIndex(2);
            elemEmitir.BtnAceptarTrasladado(driver).Click();
        }

        public void datosImpuestoRetenido(IWebDriver driver)
        {
            elemEmitir.pestaniaImpuestoRetenido(driver).Click();
            elemEmitir.BtnImpuestoRetenido(driver).Click();
            elemEmitir.SelectTipoFactorRetenido(driver).Click();
            elemEmitir.SeleccionarTipoFactorRetenido(elemEmitir.SelectTipoFactorRetenido(driver)).SelectByIndex(1);
            elemEmitir.SeleccionarTipoImpuestoRetenido(elemEmitir.SelectImpuestoRetenido(driver)).SelectByIndex(1);
            elemEmitir.SeleccionarTipoFactorRetenido(elemEmitir.SelectTipoTasaRetenido(driver)).SelectByIndex(1);
            elemEmitir.BtnAceptarRetenido(driver).Click();
        }


        public bool DevolverResultado()
        {
            return resultado;
        }
    }
}
