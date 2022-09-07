using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumPractice.PageObjects
{
    public class POEmitir
    {
        public IWebElement DivEmisor(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("div-panel-emisor"));
            return element;
        }

        public IWebElement ModalInformacion(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id='modal-captura-previa']/div/div/div[3]"));
            return element;
        }

        public IWebElement BtnSaltar(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//a[contains(text(),'Saltar')]"));
            return element;
        }

        public IWebElement BtnModalAceptar(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("btn-captura-previa-aceptar"));
            return element;
        }

        public IWebElement BtnModalCancelar(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("btn-captura-previa-cancelar"));
            return element;
        }

        public IWebElement SelectRFC(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("emisorRFC-field"));
            return element;
        }
        public SelectElement SeleccionarRFC(IWebElement select)
        {
            SelectElement element = new SelectElement(select);
            return element;
        }

        public IWebElement SelectCDS(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("emisorCSD-field"));
            return element;
        }
        public SelectElement SeleccionarCSD(IWebElement select)
        {
            SelectElement element = new SelectElement(select);
            return element;
        }
        public IWebElement CheckDireccion(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("emisorIncluirDireccion-field"));
            return element;
        }

        public IWebElement CheckNombre(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("emisorIncluirDireccion-field"));
            return element;
        }

        public IWebElement InputNombreEmisor(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("emisorNombre-field"));
            return element;
        }




        public IWebElement BtnAceptarDatosEmisor(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("emisor-btn-aceptar"));
            return element;
        }
        public IWebElement BtnCancelarDatosEmisor(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("emisor-btn-cancelar"));
            return element;
        }

        public IWebElement SelectRegimen(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("emisorRegimenFiscal-field"));
            return element;
        }

        public SelectElement SeleccionarRegimen(IWebElement select)
        {
            SelectElement element = new SelectElement(select);
            return element;
        }

        #region Datos Comprobante
        public IWebElement DivDatosComprobante(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("div-panel-datos-comprobante"));
            return element;
        }

        public IWebElement SelectTipoDocumento(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("datosComprobanteTipoDocumento-field"));
            return element;
        }

        public SelectElement SeleccionarTipoDocumento(IWebElement select)
        {
            SelectElement element = new SelectElement(select);
            return element;
        }

        public IWebElement InputExpedicion(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("datosComprobanteLugarExpedicion-field"));
            return element;
        }

        public IWebElement InputMoneda(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("datosComprobanteMoneda-field"));
            return element;
        }
        public IWebElement ListaMoneda(IWebDriver driver)
        {
            //IWebElement element = driver.FindElement(By.XPath("//div[contains(text(),'(MXN) Peso Mexicano')]"));
            IWebElement element = driver.FindElement(By.XPath("//*[@id='ui-id-1']/li"));
            return element;
        }
        //*[@id="ui-id-1"]/li


        public IWebElement InputTipoCambio(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("datosComprobanteTipoCambio-field"));
            return element;
        }
        public IWebElement InputSerie(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("datosComprobanteSerie-field"));
            return element;
        }

        public IWebElement InputFolio(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("datosComprobanteFolio-field"));
            return element;
        }

        public IWebElement InputFormaDePago(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("datosComprobanteFormaPago-field"));
            return element;
        }

        public IWebElement ListaFormaPago(IWebDriver driver, string textoForma)
        {
            // IWebElement element = driver.FindElement(By.Id("ui-id-11"));
            IWebElement element = driver.FindElement(By.XPath("//div[contains(text(),'" + textoForma + "')]"));
            return element;
        }

        public IWebElement InputMetodoDePago(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("datosComprobanteMetodoPago-field"));
            return element;
        }

        public IWebElement ListaMetodoPago(IWebDriver driver, string textoMetodo)
        {
            IWebElement element = driver.FindElement(By.XPath("//div[contains(text(),'" + textoMetodo + "')]"));
            return element;
        }

        public IWebElement InputCondicionesPago(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("datosComprobanteCondicionesPago-field"));
            return element;
        }
        public IWebElement BtnCancelar(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("datos-comprobante-btn-cancelar"));
            return element;
        }
        public IWebElement BtnAceptarComprobante(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("datos-comprobante-btn-aceptar"));
            return element;
        }


        public IWebElement BtnAceptarComprobanteRecepcion(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id='form-datos-comprobante']/div[2]/button[2]"));
            return element;
        }

        #endregion

        #region CFDIRelacionados
        public IWebElement DivDatosCFDIRelacionados(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("div-panel-CFDI-relacionado"));
            return element;
        }

        public IWebElement InputUUID(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("documentoRelacionadoUUID-field"));
            return element;
        }

        public IWebElement BtnMas(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("addCFDIRelacionado-button"));
            return element;
        }

        public IWebElement SelectUUID(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("documentoRelacionadoCFDIs-field"));
            return element;
        }
        public SelectElement SeleccionarUUID(IWebElement select)
        {
            SelectElement element = new SelectElement(select);
            return element;
        }

        public IWebElement BtnMenos(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("removeCFDIRelacionado-button"));
            return element;
        }
        public IWebElement InputTipoDeRelacion(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("documentoRelacionadoTipoRelacion-field"));
            return element;
        }

        public IWebElement BtnCancelarCDFI(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("CFDI-relacionado-btn-cancelar"));
            return element;
        }

        public IWebElement BtnCancelarAceptar(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("CFDI-relacionado-btn-aceptar"));
            return element;
        }
        #endregion

        #region DatosReceptor
        public IWebElement DivReceptor(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("div-panel-receptor"));
            return element;
        }
        public IWebElement InputReceptorRFC(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("receptorRFC-field"));
            return element;
        }

        public IWebElement SelectUsoCFDI(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("receptorUsoCFDI-field"));
            return element;
        }

        public SelectElement SeleccionarUsoCFDI(IWebElement select)
        {
            SelectElement element = new SelectElement(select);
            return element;
        }

        public IWebElement InputNombreDatosReceptor(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("receptorNombre-field"));
            return element;
        }
        public IWebElement InputResidenciaFiscal(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("receptorResidenciaFiscal-field"));
            return element;
        }

        public IWebElement InputIDTributario(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("receptorIdTributario-field"));
            return element;
        }
        public IWebElement CheckIncluirDireccion(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("receptorIncluirDireccion-field"));
            return element;
        }

        public IWebElement InputDireccionCalle(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("commonDomicilioCalle-field"));
            return element;
        }

        public IWebElement InputDireccionNumeroExt(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("commonDomicilioNoExterior-field"));
            return element;
        }

        public IWebElement InputDireccionNumeroInt(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("commonDomicilioNoInterior-field"));
            return element;
        }
        public IWebElement InputDireccionColonia(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("commonDomicilioColonia-field"));
            return element;
        }

        public IWebElement InputDireccionMunicipio(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("commonDomicilioMunicipio-field"));
            return element;
        }
        public IWebElement InputDireccionCodigo(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("commonDomicilioCodigoPostal-field"));
            return element;
        }
        public IWebElement InputDireccionLocalidad(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("commonDomicilioLocalidad-field"));
            return element;
        }

        public IWebElement InputDireccionEstado(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("commonDomicilioEstado-field"));
            return element;
        }
        public IWebElement InputDireccionPais(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("commonDomicilioPais-field"));
            return element;
        }

        public IWebElement InputDireccionReferencia(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("commonDomicilioReferencia-field"));
            return element;
        }

        public IWebElement BtnCancelarReceptor(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("commonDomicilioRefere-field"));
            return element;
        }

        public IWebElement BtnAceptarReceptor(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("receptor-btn-aceptar"));
            return element;
        }
        #endregion

        public IWebElement BtnSeleccionaPlantilla(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//a[contains(text(),'Seleccionar una plantilla')]"));
            return element;
        }

        #region Conceptos
        public IWebElement BtnAgregarConcepto(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("agregarConcepto"));
            return element;
        }

        public IWebElement InputClaveProducto(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("conceptoClaveProductoServicio-field"));
            return element;
        }

        public IWebElement ListaClaveProducto(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id='ui-id-7']/li[2]"));
            return element;
        }

        public IWebElement InputNumIdentificacion(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("conceptoNoIdentificacion-field"));
            return element;
        }

        public IWebElement InputUnidad(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("conceptoUnidad-field"));
            return element;
        }

        public IWebElement InputClaveUnidad(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("conceptoClaveUnidad-field"));
            return element;
        }

        public IWebElement ListaClaveUnidad(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("ui-id-72"));
            return element;
        }

        public IWebElement InputDescripcion(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("conceptoDescripcion-field"));
            return element;
        }

        public IWebElement InputCantidad(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("conceptoCantidad-field"));
            return element;
        }

        public IWebElement InputValorUnitario(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("conceptoValorUnitario-field"));
            return element;
        }

        public IWebElement InputDescuento(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("conceptoDescuento-field"));
            return element;
        }

        public IWebElement BtnAceptarConcepto(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("aceptarConcepto-button"));
            return element;
        }

        public IWebElement BtnImpuestoTraslado(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("impuestoTrasladadoAgregar-button"));
            return element;
        }

        public IWebElement SelectTipoFactor(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("impuestoTrasladadoTipoFactor-field"));
            return element;
        }

        public SelectElement SeleccionarTipoFactor(IWebElement select)
        {
            SelectElement element = new SelectElement(select);
            return element;
        }

        public IWebElement SelectTipoImpuesto(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("impuestoTrasladadoImpuesto-field"));
            return element;
        }

        public SelectElement SeleccionarTipoImpuesto(IWebElement select)
        {
            SelectElement element = new SelectElement(select);
            return element;
        }

        public IWebElement SelectTipoTasa(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("impuestoTrasladadoTasaCuota-field"));
            return element;
        }

        public SelectElement SeleccionarTasa(IWebElement select)
        {
            SelectElement element = new SelectElement(select);
            return element;
        }

        public IWebElement pestaniaImpuestoRetenido(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//a[contains(text(),'Retenidos')]"));
            return element;
        }



        public IWebElement BtnCancelarTrasladado(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id='impuestoTrasladado-form']/div[2]/button[1]"));
            return element;
        }

        public IWebElement BtnAceptarTrasladado(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id='impuestoTrasladado-form']/div[2]/button[2]"));
            return element;
        }

        public IWebElement BtnImpuestoRetenido(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("impuestoRetenidoAgregar-button"));
            return element;
        }


        public IWebElement SelectTipoFactorRetenido(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("impuestoRetenidoTipoFactor-field"));
            return element;
        }



        public SelectElement SeleccionarTipoFactorRetenido(IWebElement select)
        {
            SelectElement element = new SelectElement(select);
            return element;
        }

        public IWebElement SelectImpuestoRetenido(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("impuestoRetenidoImpuesto-field"));
            return element;
        }

        public SelectElement SeleccionarTipoImpuestoRetenido(IWebElement select)
        {
            SelectElement element = new SelectElement(select);
            return element;
        }


        public IWebElement SelectTipoTasaRetenido(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("impuestoRetenidoTasaCuota-field"));
            return element;
        }

        public SelectElement SeleccionarTasaRetenido(IWebElement select)
        {
            SelectElement element = new SelectElement(select);
            return element;
        }

        public IWebElement BtnCancelarRetenido(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id='impuestoRetenido-form']/div[2]/button[1]"));
            return element;
        }

        public IWebElement BtnAceptarRetenido(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id='impuestoRetenido-form']/div[2]/button[2]"));
            return element;
        }

        #endregion

        public IWebElement BtnEmitir(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//a[contains(text(),'Emitir')]"));
            return element;
        }


        public IWebElement ModalGeneracionComprobante(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id='modalRespuestaSincrono']/div/div/div[1]/h4"));
            return element;
        }

        public IWebElement BtnAceptarResultado(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("aceptarResultado-button"));
            return element;
        }

        public IWebElement BtnNuevaComprobante(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("nuevaCaptura-button"));
            return element;
        }

        public IWebElement MensajeExitoComprobante(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//p[contains(text(),'El comprobante ha sido generado con el UUID')]"));
            return element;
        }
        // El comprobante ha sido generado con el UUID 1B4772A4-3DE2-4923-AA65-32183E1D4C11

        #region Recepcion Pagos

        public IWebElement BtnAgregarPago(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id='mainContainer']/div[10]/div[2]/button"));
            return element;
        }




        public IWebElement InputFormaPagoComplemento(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("recepcionPagoFormaPago-field"));
            return element;
        }

        public IWebElement SpanCalendarioComplemento(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id='recepcionPagoFechaPago-dateGroup']/span"));
            return element;
        }


        public IWebElement MesCalendario(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.CssSelector(".datepicker-days .picker-switch"));
            return element;
        }

        public IWebElement AnioCalendario(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.CssSelector(".datepicker-months .picker-switch"));
            return element;
        }

        public IWebElement MesSelection(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.CssSelector(".month:nth-child(7)"));
            return element;
        }


        public IWebElement TablaCalendarioComplemento(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.CssSelector("Table"));
            return element;
        }


        public IWebElement DiaCalendario(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.CssSelector("tr:nth-child(2) > .day:nth-child(4)"));
            return element;
        }


        public IWebElement InputFechaFormaPago(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("recepcionPagoFechaPago-field"));
            return element;
        }

        public IWebElement ListaFormaMetodoPago(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("ui-id-7"));
            return element;
        }

        public IWebElement InputFormaPagoMoneda(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("recepcionPagoMoneda-field"));
            return element;
        }

        public IWebElement ListaMonedaPago(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("ui-id-8"));
            return element;
        }

        public IWebElement InputMontoFormaPago(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("recepcionPagoMonto-field"));
            return element;
        }

        public IWebElement BtnAceptarFormaPago(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id='recepcionPago-form']/div[2]/button[2]"));
            return element;
        }


        public IWebElement PestaniaDocumentoRelacionados(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//a[contains(text(),'Documentos relacionados')]"));
            return element;
        }

        public IWebElement BtnAgregarDocumento(IWebDriver driver)
        {

            IWebElement element = driver.FindElement(By.XPath("//*[@id='panel-recepcionPagoDocumentoRelacionado']/div/button"));
            return element;
        }
        public IWebElement ModalAgregarDocumento(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id='recepcionPagoDocumentoRelacionado-modal']/div/div"));
            return element;
        }

        public IWebElement InputIDDocumento(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("recepcionPagoDocumentoRelacionadoIdDocumento-field"));
            return element;
        }

        public IWebElement InputDocumentoMoneda(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("recepcionPagoDocumentoRelacionadoMoneda-field"));
            return element;
        }

        public IWebElement ListaDocumentoMoneda(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("/html/body/ul[6]/li/div"));
            return element;
        }

        public IWebElement InputDocumentoSerie(IWebDriver driver)
        {

            IWebElement element = driver.FindElement(By.Id("recepcionPagoDocumentoRelacionadoSerie-field"));
            return element;
        }

        public IWebElement InputDocumentoParcialidad(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id='recepcionPagoDocumentoRelacionadoNumParcialidad-field']"));
            return element;
        }
        //*[@id="recepcionPagoDocumentoRelacionadoNumParcialidad-field"]
        public IWebElement InputDocumentoSaldoAnt(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("recepcionPagoDocumentoRelacionadoImpSaldoAnt-field"));
            return element;
        }

        public IWebElement InputDocumentoPagado(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("recepcionPagoDocumentoRelacionadoImpPagado-field"));
            return element;
        }

        public IWebElement InputDocumentoSaldoInsoluto(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("recepcionPagoDocumentoRelacionadoImpSaldoInsoluto-field"));
            return element;
        }
        //*[@id="recepcionPagoDocumentoRelacionado-form"]/div[2]/button[2]
        public IWebElement BtnAddDocumentoRelacionado(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id='recepcionPagoDocumentoRelacionado-form']/div[2]/button[2]"));
            return element;
        }

        public IWebElement BtnNuevaCaptura(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("nuevaCaptura-button"));
            return element;
        }

        #endregion

        #region Nomina

        public IWebElement BtnAddNomina(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id='mainContainer']/div[9]/div[2]/button"));
            return element;
        }

        public IWebElement SelectTipoNomina(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("nominaTipoNomina-field"));
            return element;
        }

        public SelectElement SeleccionarTipoNomina(IWebElement select)
        {
            SelectElement element = new SelectElement(select);
            return element;
        }

        public IWebElement SpanCalendarioNominaFechaPago(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id='nominaFechaPago-dateGroup']/span"));
            return element;
        }

        public IWebElement SpanCalendarioNominaFechaInicio(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id='nominaFechaInicialPago-dateGroup']/span"));
            return element;
        }

        public IWebElement SpanCalendarioNominaFechaInicioLaboral(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id='nominaReceptorFechaInicioRelLaboral-dateGroup']/span"));
            return element;
        }

        public IWebElement SpanCalendarioNominaFechaFinal(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id='nominaFechaFinalPago-dateGroup']/span"));
            return element;
        }

        public IWebElement InputNominaNumDias(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("nominaNumDiasPagados-field"));
            return element;
        }

        public IWebElement InputNominaOrigenRecurso(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("nominaEmisorEntidadSNCFOrigenRecurso-field"));
            return element;
        }

        public IWebElement ListaOrigenRecurso(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//div[contains(text(),'(IF) Ingreso federales.')]"));
            return element;
        }

        public IWebElement InputNominaRegistro(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("nominaEmisorRegistroPatronal-field"));
            return element;
        }

        public IWebElement InputNominaCURP(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("nominaReceptorCURP-field"));
            return element;
        }

        public IWebElement InputSeguroSocial(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("nominaReceptorNSS-field"));
            return element;
        }

        public IWebElement InputAntiguedad(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("nominaReceptorAntiguedad-field"));
            return element;
        }

        public IWebElement InputTipoContrato(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("nominaReceptorTipoContrato-field"));
            return element;
        }
        public IWebElement ListaTipoContrato(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//div[contains(text(),'(01) Contrato de trabajo por tiempo indeterminado')]"));
            return element;
        }

        public IWebElement SelectSindicalizado(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("nominaReceptorSindicalizado-field"));
            return element;
        }

        public SelectElement SeleccionarSindicalizado(IWebElement select)
        {
            SelectElement element = new SelectElement(select);
            return element;
        }

        public IWebElement InputNominaRegimen(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("nominaReceptorTipoRegimen-field"));
            return element;
        }
        public IWebElement ListaNominaRegimen(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//div[contains(text(),'(04) Pensionados')]"));
            return element;
        }
        //  <div id="ui-id-18" tabindex="-1" class="ui-menu-item-wrapper">(02) Sueldos (Incluye ingresos señalados en la fracción I del artículo 94 de LISR)</div>
        public IWebElement InputNumeroEmpleado(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("nominaReceptorNumEmpleado-field"));
            return element;
        }

        public IWebElement InputDepartamento(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("nominaReceptorDepartamento-field"));
            return element;
        }
        public IWebElement InputPuesto(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("nominaReceptorPuesto-field"));
            return element;
        }
        public IWebElement InputRiesgoPuesto(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("nominaReceptorRiesgoPuesto-field"));
            return element;
        }

        public IWebElement ListaRiesgoPuesto(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//div[contains(text(),'(2) Clase II')]"));
            return element;
        }

        public IWebElement InputPeriodoPago(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("nominaReceptorPeriodicidadPago-field"));
            return element;
        }

        public IWebElement ListaPeriodoPago(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//div[contains(text(),'(04) Quincenal')]"));
            return element;
        }

        public IWebElement InputSalarioIntegrado(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("nominaReceptorSalarioDiarioIntegrado-field"));
            return element;
        }

        public IWebElement InputNominaEntidadFederativa(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("nominaReceptorClaveEntFed-field"));
            return element;
        }

        public IWebElement ListaNominaEntidadFederativa(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//div[contains(text(),'(AGU) Aguascalientes')]"));
            return element;
        }

        public IWebElement BtnAddSubcontrataciones(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id='scrollBlock']/div/div[5]/div[2]/div[10]/div[2]/button"));
            return element;
        }

        public IWebElement InputPorcentajeTiempo(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("nominaSubcontratacionPorcentajeTiempo-field"));
            return element;
        }
        public IWebElement InputRFCLabora(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("nominaSubcontratacionRFCLabora-field"));
            return element;
        }

        public IWebElement BtnAceptarSubcontrataciones(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id='nominaSubcontratacion-form']/div[2]/button[2]"));
            return element;
        }

        public IWebElement BtnAddPercepcion(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id='scrollBlock']/div/div[6]/div[2]/button"));
            return element;
        }

        public IWebElement InputTipoPercepcion(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("nominaPercepcionTipoPercepcion-field"));
            return element;
        }

        public IWebElement ListaTipoPercepcion2(IWebDriver driver)
        {
            //IWebElement element = driver.FindElement(By.XPath("//div[contains(text(),'(001) Sueldos, Salarios Rayas y Jornales')]"));
            IWebElement element = driver.FindElement(By.CssSelector("ui-menu-item-wrapper"));
            return element;
        }

        public IWebElement ListaTipoPercepcion(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("/html/body/ul[12]/li"));

            return element;
        }

        public IWebElement InputPercepcionClave(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("nominaPercepcionClave-field"));
            return element;
        }

        public IWebElement InputPercepcionConcepto(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("nominaPercepcionConcepto-field"));
            return element;
        }

        public IWebElement InputPercepcionImporteGravado(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("nominaPercepcionImporteGravado-field"));
            return element;
        }

        public IWebElement InputPercepcionImporteExento(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("nominaPercepcionImporteExento-field"));
            return element;
        }

        public IWebElement BtnAceptarPercepcion(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id='nominaPercepcion-form']/div[2]/button[2]"));
            return element;
        }

        public IWebElement BtnAceptarNomina(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id='nomina-form']/div[2]/button[2]"));
            return element;
        }


        #endregion


        #region INE


        public IWebElement BtnAddINE(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id='mainContainer']/div[13]/div[2]/button"));
            return element;
        }

        public IWebElement SelectTipoProceso(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("ineTipoProceso-field"));
            return element;
        }

        public SelectElement SeleccionarTipoProceso(IWebElement select)
        {
            SelectElement element = new SelectElement(select);
            return element;
        }

        public IWebElement SelectTipoComite(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("ineTipoComite-field"));
            return element;
        }

        public SelectElement SeleccionarTipoComite(IWebElement select)
        {
            SelectElement element = new SelectElement(select);
            return element;
        }

        public IWebElement BtnAddEntidad(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id='scrollBlock']/div/div[3]/div[2]/button"));
            return element;
        }

        public IWebElement SelectTipoAmbito(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("ineEntidadAmbito-field"));
            return element;
        }

        public SelectElement SeleccionarTipoAmbito(IWebElement select)
        {
            SelectElement element = new SelectElement(select);
            return element;
        }

        public IWebElement SelectClaveEntidad(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("ineEntidadClaveEntidad-field"));
            return element;
        }

        public SelectElement SeleccionarClaveEntidad(IWebElement select)
        {
            SelectElement element = new SelectElement(select);
            return element;
        }

        public IWebElement BtnAddContabilidad(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id='scrollBlock']/div/div[2]/div[2]/button"));
            return element;
        }

        public IWebElement InputIdContabilidad(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("ineContabilidadIdContabilidad-field"));
            return element;
        }

        public IWebElement BtnAceptarContabilidad(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id='ineContabilidad-form']/div/div[2]/button[2]"));
            return element;
        }

        public IWebElement BtnAceptarINE(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id='ine-form']/div[2]/button[2]"));
            return element;
        }

        #endregion

        #region ECC12 


        public IWebElement BtnAddComplementoCombustible(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id='mainContainer']/div[13]/div[2]/button"));
            return element;
        }

        public IWebElement InputNumeroCuenta(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("combustiblesNumeroDeCuenta-field"));
            return element;
        }

        public IWebElement BtnAddConceptoCombustible(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id='scrollBlock']/div/div[3]/div[2]/button"));
            return element;
        }

        public IWebElement InputIdentificadorCombustible(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("combustiblesConceptoIdentificador-field"));
            return element;
        }

        public IWebElement SpanCalendarioCombustibleFecha(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id='combustiblesConceptoFecha-dateGroup']/span"));
            return element;
        }

        public IWebElement InputRFCCombustible(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("combustiblesConceptoRFC-field"));
            return element;
        }

        public IWebElement InputClaveEstacion(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("combustiblesConceptoClaveEstacion-field"));
            return element;
        }


        public IWebElement InputClaveEstacio(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("combustiblesConceptoClaveEstacion-field"));
            return element;
        }


        public IWebElement InputCantidadCombustible(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("combustiblesConceptoCantidad-field"));
            return element;
        }

        public IWebElement SelectTipoCombustible(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("combustiblesConceptoTipoCombustible-field"));
            return element;
        }

        public SelectElement SeleccionarTipoCombustible(IWebElement select)
        {
            SelectElement element = new SelectElement(select);
            return element;
        }

        public IWebElement InputNombreCombustible(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("combustiblesConceptoNombreCombustible-field"));
            return element;
        }

        public IWebElement InputFolioCombustible(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("combustiblesConceptoFolioOperacion-field"));
            return element;
        }

        public IWebElement InputValorCombustible(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("combustiblesConceptoValorUnitario-field"));
            return element;
        }

        public IWebElement InputImporteCombustible(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("combustiblesConceptoImporte-field"));
            return element;
        }

        public IWebElement BtnAddTrasladoCombustible(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id='scrollBlock']/div/div[7]/div[2]/button"));
            return element;
        }

        public IWebElement BtnAgregarConceptoCombustible(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id='combustiblesConcepto-form']/div[2]/button[2]"));
            return element;
        }

        public IWebElement SelectCombustibleImpuesto(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("combustiblesConceptoTrasladoImpuesto-field"));
            return element;
        }

        public SelectElement SeleccionarCombustibleImpuesto(IWebElement select)
        {
            SelectElement element = new SelectElement(select);
            return element;
        }

        public IWebElement InputCombustibleTasa(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("combustiblesConceptoTrasladoTasaoCuota-field"));
            return element;
        }

        public IWebElement InputTrasladadoImporte(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("combustiblesConceptoTrasladoImporte-field"));
            return element;
        }

        public IWebElement BtnAgregarTrasladoCombustible(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id='combustiblesTraslado-form']/div/div[2]/button[2]"));
            return element;
        }

        public IWebElement BtnAceptarCombustibleConcepto(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id='combustiblesConcepto-form']/div[2]/button[2]"));
            return element;
        }

        public IWebElement BtnAceptarComplementoCombustible(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id='combustibles-form']/div[2]/button[2]"));
            return element;
        }

        #endregion


        #region Comercio 



        public IWebElement SelectMotivoTraslado(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("comercioExteriorMotivoTraslado-field"));
            return element;
        }

        public SelectElement SeleccionarMotivoTraslado(IWebElement select)
        {
            SelectElement element = new SelectElement(select);
            return element;
        }

        public IWebElement SelectCertificadoOrigen(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("comercioExteriorCertificadoOrigen-field"));
            return element;
        }

        public SelectElement SeleccionarCertificadoOrigen(IWebElement select)
        {
            SelectElement element = new SelectElement(select);
            return element;
        }

        public IWebElement SelectIncortem(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("comercioExteriorIncoterm-field"));
            return element;
        }
        //*[@id="comercioExteriorIncoterm-field"]
        public SelectElement SeleccionarIncortem(IWebElement select)
        {
            SelectElement element = new SelectElement(select);
            return element;
        }

        public IWebElement SelectComercioSubdivision(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("comercioExteriorSubdivision-field"));
            return element;
        }

        public SelectElement SeleccionarComercioSubdivision(IWebElement select)
        {
            SelectElement element = new SelectElement(select);
            return element;
        }

        public IWebElement InputComercioCalle(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("comercioExteriorEmisorDomicilioCalle-field"));
            return element;
        }

        public IWebElement SelectComercioEstado(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("comercioExteriorEmisorDomicilioEstado-field"));
            return element;
        }

        public SelectElement SeleccionarComercioEstado(IWebElement select)
        {
            SelectElement element = new SelectElement(select);
            return element;
        }

        public IWebElement SelectComercioMunicipio(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("comercioExteriorEmisorDomicilioMunicipio-field"));
            return element;
        }

        public SelectElement SeleccionarComercioMunicipio(IWebElement select)
        {
            SelectElement element = new SelectElement(select);
            return element;
        }

        public IWebElement InputComercioCodigoPostal(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("comercioExteriorEmisorDomicilioCodigoPostal-field"));
            return element;
        }

        public IWebElement SelectComercioLocalidad(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("comercioExteriorEmisorDomicilioLocalidad-field"));
            return element;
        }

        public SelectElement SeleccionarComercioLocalidad(IWebElement select)
        {
            SelectElement element = new SelectElement(select);
            return element;
        }

        public IWebElement SelectComercioColonia(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("comercioExteriorEmisorDomicilioColonia-field"));
            return element;
        }

        public SelectElement SeleccionarComercioColonia(IWebElement select)
        {
            SelectElement element = new SelectElement(select);
            return element;
        }

        public IWebElement InputComerciorReceptorCalle(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("comercioExteriorReceptorDomicilioCalle-field"));
            return element;
        }

        public IWebElement InputComerciorPais(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("comercioExteriorReceptorPais-field"));
            return element;
        }

        public IWebElement ListaComercioPaisReceptor(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//div[contains(text(),'(MEX) México')]"));
            return element;
        }

        public IWebElement ListaComercioExteriorPaisReceptor(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id='ui-id-6']/li"));
            return element;
        }

        public IWebElement InputComerciorReceptorCodigoPostal(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("comercioExteriorReceptorDomicilioCodigoPostal-field"));
            return element;
        }

        public IWebElement SelectComercioReceptorEstado(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("comercioExteriorReceptorDomicilioEstado-field"));
            return element;
        }

        public SelectElement SeleccionarComercioReceptorEstado(IWebElement select)
        {
            SelectElement element = new SelectElement(select);
            return element;
        }

        public IWebElement SelectComercioReceptorMunicipio(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("comercioExteriorReceptorDomicilioMunicipio-field"));
            return element;
        }

        public SelectElement SeleccionarComercioReceptorMunicipio(IWebElement select)
        {
            SelectElement element = new SelectElement(select);
            return element;
        }

        public IWebElement SelectComercioReceptorLocalidad(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("comercioExteriorReceptorDomicilioLocalidad-field"));
            return element;
        }

        public SelectElement SeleccionarComercioReceptorLocalidad(IWebElement select)
        {
            SelectElement element = new SelectElement(select);
            return element;
        }

        public IWebElement SelectComercioReceptorColonia(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("comercioExteriorReceptorColonia-field"));
            return element;
        }


        public SelectElement SeleccionarComercioReceptorColonia(IWebElement select)
        {
            SelectElement element = new SelectElement(select);
            return element;
        }

        public IWebElement PestaniaAddComercioMercancias(IWebDriver driver)
        {
            // IWebElement element = driver.FindElement(By.XPath("//*[@id='scrollBlock']/div/div[11]/div[2]/button"));
            IWebElement element = driver.FindElement(By.XPath("//a[contains(text(),'Mercancias')]"));
            return element;
        }

        public IWebElement BtnAddComercioMercancias(IWebDriver driver)
        {
            // IWebElement element = driver.FindElement(By.XPath("//*[@id='scrollBlock']/div/div[11]/div[2]/button"));
            IWebElement element = driver.FindElement(By.XPath("//*[@id='panel-comercioExteriorMercancia']/div/button"));
            return element;
        }

        public IWebElement InputComerciorMercanciaNIdentificacion(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("comercioExteriorMercanciaNoIdentificacion-field"));
            return element;
        }

        public IWebElement InputComerciorMercanciaFraccionArancel(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("comercioExteriorMercanciaFraccionArancelaria-field"));
            return element;
        }

        public IWebElement ListaComerciorMercanciaFraccionArancel(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath(" //*[@id='ui-id-13']/li[1]"));
            // IWebElement element = driver.FindElement(By.XPath("//div[contains(text(),'(08094001) Ciruelas y endrinas.')]"));
            return element;
        }

        public IWebElement InputComerciorMercanciaCantidadAduana(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("comercioExteriorMercanciaCantidadAduana-field"));
            return element;
        }

        public IWebElement SelectComercioUnidadAduana(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("comercioExteriorMercanciaUnidadAduana-field"));
            return element;
        }

        public SelectElement SeleccionarComercioUnidadAduana(IWebElement select)
        {
            SelectElement element = new SelectElement(select);
            return element;
        }

        public IWebElement InputComerciorMercanciaUnitarioAduana(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("comercioExteriorMercanciaValorUnitarioAduana-field"));
            return element;
        }

        public IWebElement InputComerciorMercanciaValorDolares(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("comercioExteriorMercanciaValorDolares-field"));
            return element;
        }

        public IWebElement BtnAgregarMercancias(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id='comercioExteriorMercancia-form']/div/div[2]/button[2]"));
            return element;
        }

        public IWebElement BtnAgregarComercioExterior(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id='comercioExterior-form']/div[2]/button[2]"));
            return element;
        }

        #endregion

        #region Hidrocarburos

        public IWebElement DivHidrocarburos(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id='mainContainer']/div[13]/div[1]"));
            return element;
        }

        public IWebElement DivImpuestos(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("panel-header-impuestosResumen"));
            return element;
        }

        public IWebElement DivCFDIRelacionado(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("div-panel-CFDI-relacionado"));
            return element;
        }

        public IWebElement InputHidrocarburosNumContrato(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("gastosHidrocarburosNumeroContrato-field"));
            return element;
        }

        public IWebElement PestiniaAgregarErogacion(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//a[contains(text(),'Erogaciones')]"));
            return element;

        }

        public IWebElement BtnAgregarErogacion(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id='panel-gastosHidrocarburosErogacion']/div/button"));
            return element;
            //*[@id="panel-gastosHidrocarburosErogacion"]/div/button
        }

        public IWebElement SelectHidrocarburosErogaciones(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("gastosHidrocarburosErogacionTipoErogacion-field"));
            return element;
        }

        public SelectElement SeleccionarHidrocarburosErogaciones(IWebElement select)
        {
            SelectElement element = new SelectElement(select);
            return element;
        }

        public IWebElement InputHidrocarburosPorcentaje(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("gastosHidrocarburosErogacionPorcentaje-field"));
            return element;
        }

        public IWebElement InputHidrocarburosMonto(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("gastosHidrocarburosErogacionMontocuErogacion-field"));
            return element;
        }

        public IWebElement PestiniaErogacionDocumentoRelacionado(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//a[contains(text(),'Documentos Relacionados')]"));
            return element;

        }

        public IWebElement BtnAgregarDocumentoRelacionado(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id='panel-gastosHidrocarburosDocumentoRelacionado']/div/button"));
            return element;
        }

        public IWebElement SelectHidrocarburosErogacionesOrigen(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("gastosHidrocarburosDocumentoRelacionadoOrigenErogacion-field"));
            return element;
        }

        public SelectElement SeleccionarHidrocarburosErogacionesOrigen(IWebElement select)
        {
            SelectElement element = new SelectElement(select);
            return element;
        }

        public IWebElement InputHidrocarburosTotalErogacion(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("gastosHidrocarburosDocumentoRelacionadoMontoTotalErogaciones-field"));
            return element;
        }

        public IWebElement SelectHidrocarburosErogacionesMes(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("gastosHidrocarburosDocumentoRelacionadoMes-field"));
            return element;
        }

        public SelectElement SeleccionarHidrocarburosErogacionesMes(IWebElement select)
        {
            SelectElement element = new SelectElement(select);
            return element;
        }

        public IWebElement InputHidrocarburosFolioFiscal(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("gastosHidrocarburosDocumentoRelacionadoFolioFiscalVinculado-field"));
            return element;
        }

        public IWebElement BtnAceptarDocumentoRelacionado(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id='gastosHidrocarburosDocumentoRelacionado-form']/div[2]/button[2]"));
            return element;
        }

        public IWebElement BtnAceptarErogacion(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("/html/body/div[2]/div/div[15]/div/div/form/div[2]/button[2]"));
            return element;
        }


        public IWebElement BtnAceptarHidrocarburos(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id='gastosHidrocarburos-form']/div[2]/button[2]"));
            return element;
        }
        //*[@id="gastosHidrocarburos-form"]/div[2]/button[2]

        #endregion
    }
}
