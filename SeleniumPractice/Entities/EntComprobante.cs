using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPractice.Entities
{
    public class EntComprobante
    {
        private string tipoDocumento;
        private string expedicion;
        private string moneda;
        private string serie;
        private string formaPago;
        private string metodoPago;
        private Emisor emisor;
        private Receptor receptor;
        private Concepto concepto;
        private ComplementoPago complemento;
        private Nomina nomina;
        private Combustible combustible;
        private ComercioExterior comercioExterior;
        private Hidrocarburos hidrocarburos;
        private Retenciones retenciones;

        public string TipoDocumento
        {
            get
            {
                return tipoDocumento;
            }
            set
            {
                if (value == null)
                    this.tipoDocumento = string.Empty;
                else
                    this.tipoDocumento = value;
            }
        }

        public string Expedicion
        {
            get
            {
                return expedicion;
            }
            set
            {
                if (value == null)
                    this.expedicion = string.Empty;
                else
                    this.expedicion = value;
            }
        }

        public string Moneda
        {
            get
            {
                return moneda;
            }
            set
            {
                if (value == null)
                    this.moneda = string.Empty;
                else
                    this.moneda = value;
            }
        }

        public string Serie
        {
            get
            {
                return serie;
            }
            set
            {
                if (value == null)
                    this.serie = string.Empty;
                else
                    this.serie = value;
            }
        }

        public string FormaPago
        {
            get
            {
                return formaPago;
            }
            set
            {
                if (value == null)
                    this.formaPago = string.Empty;
                else
                    this.formaPago = value;
            }
        }

        public string MetodoPago
        {
            get
            {
                return metodoPago;
            }
            set
            {
                if (value == null)
                    this.metodoPago = string.Empty;
                else
                    this.metodoPago = value;
            }
        }

        public Emisor EmisorDatos
        {
            get
            {
                return emisor;
            }
            set
            {
                if (value == null)
                    this.emisor = null;
                else
                    this.emisor = value;
            }
        }

        public Receptor ReceptorDatos
        {
            get
            {
                return receptor;
            }
            set
            {
                if (value == null)
                    this.receptor = null;
                else
                    this.receptor = value;
            }
        }

        public Concepto ConceptoDatos
        {
            get
            {
                return concepto;
            }
            set
            {
                if (value == null)
                    this.concepto = null;
                else
                    this.concepto = value;
            }
        }

        public ComplementoPago ComplementoPago
        {
            get
            {
                return complemento;
            }
            set
            {
                if (value == null)
                    this.complemento = null;
                else
                    this.complemento = value;
            }
        }

        public Nomina Nomina
        {
            get
            {
                return nomina;
            }
            set
            {
                if (value == null)
                    this.nomina = null;
                else
                    this.nomina = value;
            }
        }

        public Combustible Combustible
        {
            get
            {
                return combustible;
            }
            set
            {
                if (value == null)
                    this.combustible = null;
                else
                    this.combustible = value;
            }
        }

        public ComercioExterior ComercioExt
        {
            get
            {
                return comercioExterior;
            }
            set
            {
                if (value == null)
                    this.comercioExterior = null;
                else
                    this.comercioExterior = value;
            }
        }

        public Hidrocarburos Hidrocarburos
        {
            get
            {
                return hidrocarburos;
            }
            set
            {
                if (value == null)
                    this.hidrocarburos = null;
                else
                    this.hidrocarburos = value;
            }
        }

        public Retenciones Retenciones
        {
            get
            {
                return retenciones;
            }
            set
            {
                if (value == null)
                    this.retenciones = null;
                else
                    this.retenciones = value;
            }
        }


        public static EntComprobante Init(string tipoDocumento, string expedicion, string moneda, string serie, string formaPAGO, string metodoPago,
                                            Emisor emi, Receptor receptor, Concepto concepto, ComplementoPago complemento, Nomina nomina,
                                            Combustible combustible, ComercioExterior comercio, Hidrocarburos hidro, Retenciones retencion)
        {
            EntComprobante objComprobante = new EntComprobante();
            objComprobante.TipoDocumento = tipoDocumento;
            objComprobante.Expedicion = expedicion;
            objComprobante.Moneda = moneda;
            objComprobante.Serie = serie;
            objComprobante.FormaPago = formaPAGO;
            objComprobante.MetodoPago = metodoPago;
            objComprobante.EmisorDatos = emi;
            objComprobante.ReceptorDatos = receptor;
            objComprobante.ConceptoDatos = concepto;
            objComprobante.ComplementoPago = complemento;
            objComprobante.Nomina = nomina;
            objComprobante.Combustible = combustible;
            objComprobante.ComercioExt = comercio;
            objComprobante.Hidrocarburos = hidro;
            objComprobante.Retenciones = retencion;
            return objComprobante;
        }


    }

    public class Emisor
    {

        private string rfc;

        public string RFC
        {
            get
            {
                return rfc;
            }
            set
            {
                if (value == null)
                    this.rfc = string.Empty;
                else
                    this.rfc = value;
            }
        }

        public static Emisor Init(string rfc)
        {
            Emisor objEmisor = new Emisor();
            objEmisor.RFC = rfc;
            return objEmisor;
        }

    }

    public class Receptor
    {
        private string rfcReceptor;
        private string usoCFDI;
        private string nombre;
        private string residenciaFiscal;
        private string idTributario;


        public string RFCReceptor
        {
            get
            {
                return rfcReceptor;
            }
            set
            {
                if (value == null)
                    this.rfcReceptor = string.Empty;
                else
                    this.rfcReceptor = value;
            }
        }

        public string UsoCFDI
        {
            get
            {
                return usoCFDI;
            }
            set
            {
                if (value == null)
                    this.usoCFDI = string.Empty;
                else
                    this.usoCFDI = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                if (value == null)
                    this.nombre = string.Empty;
                else
                    this.nombre = value;
            }
        }

        public string ResidenciaFiscal
        {
            get
            {
                return residenciaFiscal;
            }
            set
            {
                if (value == null)
                    this.residenciaFiscal = string.Empty;
                else
                    this.residenciaFiscal = value;
            }
        }

        public string IDTributario
        {
            get
            {
                return idTributario;
            }
            set
            {
                if (value == null)
                    this.idTributario = string.Empty;
                else
                    this.idTributario = value;
            }
        }

        public static Receptor Init(string rfcRecep, string usoCFDI, string nombre, string residencia, string id)
        {
            Receptor objReceptor = new Receptor();
            objReceptor.RFCReceptor = rfcRecep;
            objReceptor.UsoCFDI = usoCFDI;
            objReceptor.Nombre = nombre;
            objReceptor.ResidenciaFiscal = residencia;
            objReceptor.IDTributario = id;
            return objReceptor;
        }
    }

    public class Concepto
    {
        private string claveProducto;
        private string numIdentificacion;
        private string unidad;
        private string claveUnidad;
        private string descripcion;
        private string cantidad;
        private string valorUnitario;
        private string descuento;



        public string ClaveProducto
        {
            get
            {
                return claveProducto;
            }
            set
            {
                if (value == null)
                    this.claveProducto = string.Empty;
                else
                    this.claveProducto = value;
            }
        }

        public string Unidad
        {
            get
            {
                return unidad;
            }
            set
            {
                if (value == null)
                    this.unidad = string.Empty;
                else
                    this.unidad = value;
            }
        }

        public string ClaveUnidad
        {
            get
            {
                return claveUnidad;
            }
            set
            {
                if (value == null)
                    this.claveUnidad = string.Empty;
                else
                    this.claveUnidad = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }
            set
            {
                if (value == null)
                    this.descripcion = string.Empty;
                else
                    this.descripcion = value;
            }
        }

        public string Cantidad
        {
            get
            {
                return cantidad;
            }
            set
            {
                if (value == null)
                    this.cantidad = string.Empty;
                else
                    this.cantidad = value;
            }
        }

        public string ValorUnitario
        {
            get
            {
                return valorUnitario;
            }
            set
            {
                if (value == null)
                    this.valorUnitario = string.Empty;
                else
                    this.valorUnitario = value;
            }
        }

        public string Descuento
        {
            get
            {
                return descuento;
            }
            set
            {
                if (value == null)
                    this.descuento = string.Empty;
                else
                    this.descuento = value;
            }
        }


        public string NumIdentificacion
        {
            get
            {
                return numIdentificacion;
            }
            set
            {
                if (value == null)
                    this.numIdentificacion = string.Empty;
                else
                    this.numIdentificacion = value;
            }
        }


        public static Concepto Init(string clave, string unidad, string numIdenti, string claveunidad, string descripcion, string cantidad, string valorUnitario, string descuento)
        {
            Concepto objConcepto = new Concepto();
            objConcepto.ClaveProducto = clave;
            objConcepto.Unidad = unidad;
            objConcepto.NumIdentificacion = numIdenti;
            objConcepto.ClaveUnidad = claveunidad;
            objConcepto.Descripcion = descripcion;
            objConcepto.Cantidad = cantidad;
            objConcepto.ValorUnitario = valorUnitario;
            objConcepto.Descuento = descuento;
            return objConcepto;
        }

    }


    public class ComplementoPago
    {
        private string fechaPago;
        private string formaPago;
        private string monto;
        private string idDocumento;
        private string parcialidad;
        private string saldoAnterior;
        private string importePagado;
        private string importeInsoluto;

        public string FechaPago
        {
            get
            {
                return fechaPago;
            }
            set
            {
                if (value == null)
                    this.fechaPago = string.Empty;
                else
                    this.fechaPago = value;
            }
        }

        public string FormaPago
        {
            get
            {
                return formaPago;
            }
            set
            {
                if (value == null)
                    this.formaPago = string.Empty;
                else
                    this.formaPago = value;
            }
        }


        public string Monto
        {
            get
            {
                return monto;
            }
            set
            {
                if (value == null)
                    this.monto = string.Empty;
                else
                    this.monto = value;
            }
        }

        public string IdDocumento
        {
            get
            {
                return idDocumento;
            }
            set
            {
                if (value == null)
                    this.idDocumento = string.Empty;
                else
                    this.idDocumento = value;
            }
        }

        public string Parcialidad
        {
            get
            {
                return parcialidad;
            }
            set
            {
                if (value == null)
                    this.parcialidad = string.Empty;
                else
                    this.parcialidad = value;
            }
        }


        public string SaldoAnterior
        {
            get
            {
                return saldoAnterior;
            }
            set
            {
                if (value == null)
                    this.saldoAnterior = string.Empty;
                else
                    this.saldoAnterior = value;
            }
        }

        public string ImportePagado
        {
            get
            {
                return importePagado;
            }
            set
            {
                if (value == null)
                    this.importePagado = string.Empty;
                else
                    this.importePagado = value;
            }
        }


        public string ImporteInsoluto
        {
            get
            {
                return importeInsoluto;
            }
            set
            {
                if (value == null)
                    this.importeInsoluto = string.Empty;
                else
                    this.importeInsoluto = value;
            }
        }

        public static ComplementoPago Init(string fecha, string forma, string numIden, string monto, string idDoc, string parcialidad, string saldo, string pagado, string insoluto)
        {
            ComplementoPago objComplemento = new ComplementoPago();
            objComplemento.FechaPago = fecha;
            objComplemento.FormaPago = forma;
            objComplemento.Monto = monto;
            objComplemento.IdDocumento = idDoc;
            objComplemento.Parcialidad = parcialidad;
            objComplemento.SaldoAnterior = saldo;
            objComplemento.ImportePagado = pagado;
            objComplemento.ImporteInsoluto = insoluto;
            return objComplemento;
        }
    }

    public class Nomina
    {
        private string fechaPago;
        private string fechaInicio;
        private string fechaFinal;
        private string fechaContrato;
        private string numeroDias;
        private string registro;
        private string curp;
        private string seguroSocial;
        private string antiguedad;
        private string tipoContrato;
        private string regimen;
        private string numEmpleado;
        private string departamento;
        private string riesgoPuesto;
        private string periodoPago;
        private string salario;
        private string entidad;
        private string porcentaje;
        private string rfcLabora;
        private string percepcion;
        private string clavePercepcion;
        private string concepto;
        private string importeGravado;
        private string importeExento;

        public static Nomina Init(string fechaPago, string fechaInicio, string fechaFinal, string fechaContrato, string numeroD, string registro, string curp, string SSN, string anti,
                                  string contrato, string regimen, string numEmpleado, string depto, string riesgo, string periodo, string salario, string entidad,
                                   string porcentaje, string rfcLabora, string percepcion, string clavePercepcion, string concepto, string importeGravado, string exento)
        {
            Nomina objNomina = new Nomina();
            objNomina.FechaPago = fechaPago;
            objNomina.FechaInicio = fechaInicio;
            objNomina.FechaFinal = fechaFinal;
            objNomina.FechaContrato = fechaContrato;
            objNomina.NumDias = numeroD;
            objNomina.Registro = registro;
            objNomina.CURP = curp;
            objNomina.SeguroSocial = SSN;
            objNomina.Antiguedad = anti;
            objNomina.TipoContrato = contrato;
            objNomina.Regimen = regimen;
            objNomina.NumEmpleado = numEmpleado;
            objNomina.Departamento = depto;
            objNomina.RiesgoPuesto = riesgo;
            objNomina.PeriodoPago = periodo;
            objNomina.Salario = salario;
            objNomina.Entidad = entidad;
            objNomina.Porcentaje = porcentaje;
            objNomina.RFCLabora = rfcLabora;
            objNomina.Percepcion = percepcion;
            objNomina.ClavePercepcion = clavePercepcion;
            objNomina.Concepto = concepto;
            objNomina.ImporteGravado = importeGravado;
            objNomina.ImporteExento = exento;
            return objNomina;
        }

        public string FechaPago
        {
            get
            {
                return fechaPago;
            }
            set
            {
                if (value == null)
                    this.fechaPago = string.Empty;
                else
                    this.fechaPago = value;
            }
        }

        public string FechaInicio
        {
            get
            {
                return fechaInicio;
            }
            set
            {
                if (value == null)
                    this.fechaInicio = string.Empty;
                else
                    this.fechaInicio = value;
            }
        }

        public string FechaFinal
        {
            get
            {
                return fechaFinal;
            }
            set
            {
                if (value == null)
                    this.fechaFinal = string.Empty;
                else
                    this.fechaFinal = value;
            }
        }

        public string FechaContrato
        {
            get
            {
                return fechaContrato;
            }
            set
            {
                if (value == null)
                    this.fechaContrato = string.Empty;
                else
                    this.fechaContrato = value;
            }
        }

        public string NumDias
        {
            get
            {
                return numeroDias;
            }
            set
            {
                if (value == null)
                    this.numeroDias = string.Empty;
                else
                    this.numeroDias = value;
            }
        }

        public string Registro
        {
            get
            {
                return registro;
            }
            set
            {
                if (value == null)
                    this.registro = string.Empty;
                else
                    this.registro = value;
            }
        }

        public string CURP
        {
            get
            {
                return curp;
            }
            set
            {
                if (value == null)
                    this.curp = string.Empty;
                else
                    this.curp = value;
            }
        }

        public string SeguroSocial
        {
            get
            {
                return seguroSocial;
            }
            set
            {
                if (value == null)
                    this.seguroSocial = string.Empty;
                else
                    this.seguroSocial = value;
            }
        }

        public string Antiguedad
        {
            get
            {
                return antiguedad;
            }
            set
            {
                if (value == null)
                    this.antiguedad = string.Empty;
                else
                    this.antiguedad = value;
            }
        }

        public string TipoContrato
        {
            get
            {
                return tipoContrato;
            }
            set
            {
                if (value == null)
                    this.tipoContrato = string.Empty;
                else
                    this.tipoContrato = value;
            }
        }

        public string Regimen
        {
            get
            {
                return regimen;
            }
            set
            {
                if (value == null)
                    this.regimen = string.Empty;
                else
                    this.regimen = value;
            }
        }

        public string PeriodoPago
        {
            get
            {
                return periodoPago;
            }
            set
            {
                if (value == null)
                    this.periodoPago = string.Empty;
                else
                    this.periodoPago = value;
            }
        }

        public string NumEmpleado
        {
            get
            {
                return numEmpleado;
            }
            set
            {
                if (value == null)
                    this.numEmpleado = string.Empty;
                else
                    this.numEmpleado = value;
            }
        }

        public string Departamento
        {
            get
            {
                return departamento;
            }
            set
            {
                if (value == null)
                    this.departamento = string.Empty;
                else
                    this.departamento = value;
            }
        }

        public string RiesgoPuesto
        {
            get
            {
                return riesgoPuesto;
            }
            set
            {
                if (value == null)
                    this.riesgoPuesto = string.Empty;
                else
                    this.riesgoPuesto = value;
            }
        }

        public string Salario
        {
            get
            {
                return salario;
            }
            set
            {
                if (value == null)
                    this.salario = string.Empty;
                else
                    this.salario = value;
            }
        }

        public string Entidad
        {
            get
            {
                return entidad;
            }
            set
            {
                if (value == null)
                    this.entidad = string.Empty;
                else
                    this.entidad = value;
            }
        }

        public string Porcentaje
        {
            get
            {
                return porcentaje;
            }
            set
            {
                if (value == null)
                    this.porcentaje = string.Empty;
                else
                    this.porcentaje = value;
            }
        }

        public string RFCLabora
        {
            get
            {
                return rfcLabora;
            }
            set
            {
                if (value == null)
                    this.rfcLabora = string.Empty;
                else
                    this.rfcLabora = value;
            }
        }

        public string Percepcion
        {
            get
            {
                return percepcion;
            }
            set
            {
                if (value == null)
                    this.percepcion = string.Empty;
                else
                    this.percepcion = value;
            }
        }

        public string ClavePercepcion
        {
            get
            {
                return clavePercepcion;
            }
            set
            {
                if (value == null)
                    this.clavePercepcion = string.Empty;
                else
                    this.clavePercepcion = value;
            }
        }

        public string Concepto
        {
            get
            {
                return concepto;
            }
            set
            {
                if (value == null)
                    this.concepto = string.Empty;
                else
                    this.concepto = value;
            }
        }

        public string ImporteGravado
        {
            get
            {
                return importeGravado;
            }
            set
            {
                if (value == null)
                    this.importeGravado = string.Empty;
                else
                    this.importeGravado = value;
            }
        }

        public string ImporteExento
        {
            get
            {
                return importeExento;
            }
            set
            {
                if (value == null)
                    this.importeExento = string.Empty;
                else
                    this.importeExento = value;
            }
        }

    }

    public class Combustible
    {
        private string numeroCuenta;
        private string idCombustible;
        private string fechaCombustible;
        private string rfcCombustible;
        private string claveEstacion;
        private string cantidad;
        private string nombre;
        private string folio;
        private string valor;
        private string importe;
        private string tasa;
        private string trasladoImporte;

        public static Combustible Init(string numero, string idCombustible, string fechaCombustible, string rfc, string clave, string cantidad, string nombre, string folio, string valor,
                                        string importe, string tasa, string traslado)
        {
            Combustible objCombustible = new Combustible();
            objCombustible.NumeroCuenta = numero;
            objCombustible.IdCombustible = idCombustible;
            objCombustible.CombustibleFecha = fechaCombustible;
            objCombustible.RFCCombustible = rfc;
            objCombustible.ClaveEstacion = clave;
            objCombustible.Cantidad = cantidad;
            objCombustible.Nombre = nombre;
            objCombustible.Folio = folio;
            objCombustible.Valor = valor;
            objCombustible.Importe = importe;
            objCombustible.Tasa = tasa;
            objCombustible.ImporteTraslado = traslado;
            return objCombustible;
        }


        public string NumeroCuenta
        {
            get
            {
                return numeroCuenta;
            }
            set
            {
                if (value == null)
                    this.numeroCuenta = string.Empty;
                else
                    this.numeroCuenta = value;
            }
        }

        public string IdCombustible
        {
            get
            {
                return idCombustible;
            }
            set
            {
                if (value == null)
                    this.idCombustible = string.Empty;
                else
                    this.idCombustible = value;
            }
        }

        public string CombustibleFecha
        {
            get
            {
                return fechaCombustible;
            }
            set
            {
                if (value == null)
                    this.fechaCombustible = string.Empty;
                else
                    this.fechaCombustible = value;
            }
        }

        public string RFCCombustible
        {
            get
            {
                return rfcCombustible;
            }
            set
            {
                if (value == null)
                    this.rfcCombustible = string.Empty;
                else
                    this.rfcCombustible = value;
            }
        }

        public string ClaveEstacion
        {
            get
            {
                return claveEstacion;
            }
            set
            {
                if (value == null)
                    this.claveEstacion = string.Empty;
                else
                    this.claveEstacion = value;
            }
        }

        public string Cantidad
        {
            get
            {
                return cantidad;
            }
            set
            {
                if (value == null)
                    this.cantidad = string.Empty;
                else
                    this.cantidad = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                if (value == null)
                    this.nombre = string.Empty;
                else
                    this.nombre = value;
            }
        }

        public string Folio
        {
            get
            {
                return folio;
            }
            set
            {
                if (value == null)
                    this.folio = string.Empty;
                else
                    this.folio = value;
            }
        }

        public string Valor
        {
            get
            {
                return valor;
            }
            set
            {
                if (value == null)
                    this.valor = string.Empty;
                else
                    this.valor = value;
            }
        }

        public string Importe
        {
            get
            {
                return importe;
            }
            set
            {
                if (value == null)
                    this.importe = string.Empty;
                else
                    this.importe = value;
            }
        }

        public string Tasa
        {
            get
            {
                return tasa;
            }
            set
            {
                if (value == null)
                    this.tasa = string.Empty;
                else
                    this.tasa = value;
            }
        }

        public string ImporteTraslado
        {
            get
            {
                return trasladoImporte;
            }
            set
            {
                if (value == null)
                    this.trasladoImporte = string.Empty;
                else
                    this.trasladoImporte = value;
            }
        }

    }

    public class ComercioExterior
    {
        private string numIdentificacion;
        private string fraccionArancel;
        private string cantidadAduana;
        private string unitarioAduana;
        private string valorDolares;

        public static ComercioExterior Init(string numIdentifica, string fraccion, string cantidad, string unitario, string valor)
        {
            ComercioExterior objComercio = new ComercioExterior();
            objComercio.NumIdentificacion = numIdentifica;
            objComercio.FraccionArancel = fraccion;
            objComercio.CantidadAduana = cantidad;
            objComercio.UnitarioAduana = unitario;
            objComercio.ValorDolares = valor;

            return objComercio;
        }


        public string NumIdentificacion
        {
            get
            {
                return numIdentificacion;
            }
            set
            {
                if (value == null)
                    this.numIdentificacion = string.Empty;
                else
                    this.numIdentificacion = value;
            }
        }

        public string FraccionArancel
        {
            get
            {
                return fraccionArancel;
            }
            set
            {
                if (value == null)
                    this.fraccionArancel = string.Empty;
                else
                    this.fraccionArancel = value;
            }
        }

        public string CantidadAduana
        {
            get
            {
                return cantidadAduana;
            }
            set
            {
                if (value == null)
                    this.cantidadAduana = string.Empty;
                else
                    this.cantidadAduana = value;
            }
        }

        public string UnitarioAduana
        {
            get
            {
                return unitarioAduana;
            }
            set
            {
                if (value == null)
                    this.unitarioAduana = string.Empty;
                else
                    this.unitarioAduana = value;
            }
        }

        public string ValorDolares
        {
            get
            {
                return valorDolares;
            }
            set
            {
                if (value == null)
                    this.valorDolares = string.Empty;
                else
                    this.valorDolares = value;
            }
        }
    }

    public class Hidrocarburos
    {
        private string numContrato;
        private string monto;
        private string porcentaje;
        private string erogacionOrigen;
        private string total;
        private string erogacionMes;


        public static Hidrocarburos Init(string num, string monto, string porcentaje, string origen, string total, string mes)
        {
            Hidrocarburos objHidro = new Hidrocarburos();
            objHidro.NumContrato = num;
            objHidro.Monto = monto;
            objHidro.Porcentaje = porcentaje;
            objHidro.ErogacionOrigen = origen;
            objHidro.Total = total;
            objHidro.ErogacionMes = mes;
            return objHidro;

        }


        public string NumContrato
        {
            get
            {
                return numContrato;
            }
            set
            {
                if (value == null)
                    this.numContrato = string.Empty;
                else
                    this.numContrato = value;
            }
        }


        public string Monto
        {
            get
            {
                return monto;
            }
            set
            {
                if (value == null)
                    this.monto = string.Empty;
                else
                    this.monto = value;
            }
        }

        public string Porcentaje
        {
            get
            {
                return porcentaje;
            }
            set
            {
                if (value == null)
                    this.porcentaje = string.Empty;
                else
                    this.porcentaje = value;
            }
        }

        public string ErogacionOrigen
        {
            get
            {
                return erogacionOrigen;
            }
            set
            {
                if (value == null)
                    this.erogacionOrigen = string.Empty;
                else
                    this.erogacionOrigen = value;
            }
        }

        public string Total
        {
            get
            {
                return total;
            }
            set
            {
                if (value == null)
                    this.total = string.Empty;
                else
                    this.total = value;
            }
        }

        public string ErogacionMes
        {
            get
            {
                return erogacionMes;
            }
            set
            {
                if (value == null)
                    this.erogacionMes = string.Empty;
                else
                    this.erogacionMes = value;
            }
        }

    }

    public class Retenciones
    {
        private string folioInterno;
        private string tipoDocumento;
        private string retencion;
        private string mesInicial;
        private string mesFinal;
        private string anioEjercicio;
        private string total;
        private string gravable;
        private string exento;
        private PlanRetiro planesRetiro;

        public static Retenciones Init(string folio, string tipo, string retencion, string mesInicio, string mesFinal, string anio, string total, string grabable, string exento, PlanRetiro plan)
        {
            Retenciones objRetenciones = new Retenciones();
            objRetenciones.FolioInterno = folio;
            objRetenciones.TipoDocumento = tipo;
            objRetenciones.Retencion = retencion;
            objRetenciones.MesInicial = mesInicio;
            objRetenciones.MesFinal = mesFinal;
            objRetenciones.AnioEjercicio = anio;
            objRetenciones.Total = total;
            objRetenciones.Gravable = grabable;
            objRetenciones.Exento = exento;
            objRetenciones.PlanesRetiro = plan;
            return objRetenciones;
        }


        public string FolioInterno
        {
            get
            {
                return folioInterno;
            }
            set
            {
                if (value == null)
                    this.folioInterno = string.Empty;
                else
                    this.folioInterno = value;
            }
        }

        public string TipoDocumento
        {
            get
            {
                return tipoDocumento;
            }
            set
            {
                if (value == null)
                    this.tipoDocumento = string.Empty;
                else
                    this.tipoDocumento = value;
            }
        }

        public string Retencion
        {
            get
            {
                return retencion;
            }
            set
            {
                if (value == null)
                    this.retencion = string.Empty;
                else
                    this.retencion = value;
            }
        }

        public string MesInicial
        {
            get
            {
                return mesInicial;
            }
            set
            {
                if (value == null)
                    this.mesInicial = string.Empty;
                else
                    this.mesInicial = value;
            }
        }

        public string MesFinal
        {
            get
            {
                return mesFinal;
            }
            set
            {
                if (value == null)
                    this.mesFinal = string.Empty;
                else
                    this.mesFinal = value;
            }
        }

        public string AnioEjercicio
        {
            get
            {
                return anioEjercicio;
            }
            set
            {
                if (value == null)
                    this.anioEjercicio = string.Empty;
                else
                    this.anioEjercicio = value;
            }
        }


        public string Total
        {
            get
            {
                return total;
            }
            set
            {
                if (value == null)
                    this.total = string.Empty;
                else
                    this.total = value;
            }
        }

        public string Gravable
        {
            get
            {
                return gravable;
            }
            set
            {
                if (value == null)
                    this.gravable = string.Empty;
                else
                    this.gravable = value;
            }
        }

        public string Exento
        {
            get
            {
                return exento;
            }
            set
            {
                if (value == null)
                    this.exento = string.Empty;
                else
                    this.exento = value;
            }
        }

        public PlanRetiro PlanesRetiro
        {
            get
            {
                return planesRetiro;
            }
            set
            {
                if (value == null)
                    this.planesRetiro = null;
                else
                    this.planesRetiro = value;
            }
        }


    }


    public class PlanRetiro
    {
        private string sistemaFinan;
        private string montTotAportAnioInmAnterior;
        private string montIntRealesDevengAnioInmAnt;
        private string huboRetirosAnioInmAntPer;
        private string montTotRetiradoAnioInmAntPer;
        private string montTotExentRetiradoAnioInmAnt;
        private string montTotExedenteAnioInmAnt;
        private string huboRetirosAnioInmAnt;
        private string montTotRetiradoAnioInmAnt;
        private string numReferencia;


        public static PlanRetiro Init(string sistema, string montTotAporte, string monIntReales, string huboRetiros, string montRetiradoAnio, string montToExento, string montTotExedente, string huboRetirosAnioInmAnt, string montTotAnionte, string num)
        {
            PlanRetiro objPlanRetiro = new PlanRetiro();
            objPlanRetiro.SistemaFinan = sistema;
            objPlanRetiro.MontTotAportAnioInmAnterior = montTotAporte;
            objPlanRetiro.MontIntRealesDevengAnioInmAnt = monIntReales;
            objPlanRetiro.HuboRetirosAnioInmAntPer = huboRetiros;
            objPlanRetiro.MontTotRetiradoAnioInmAntPer = montRetiradoAnio;
            objPlanRetiro.MontTotExentRetiradoAnioInmAnt = montToExento;
            objPlanRetiro.MontTotExedenteAnioInmAnt = montTotExedente;
            objPlanRetiro.HuboRetirosAnioInmAnt = huboRetirosAnioInmAnt;
            objPlanRetiro.MontTotRetiradoAnioInmAnt = montTotAnionte;
            objPlanRetiro.NumReferencia = num;

            return objPlanRetiro;
        }



        public string SistemaFinan
        {
            get
            {
                return sistemaFinan;
            }
            set
            {
                if (value == null)
                    this.sistemaFinan = string.Empty;
                else
                    this.sistemaFinan = value;
            }
        }

        public string MontTotAportAnioInmAnterior
        {
            get
            {
                return montTotAportAnioInmAnterior;
            }
            set
            {
                if (value == null)
                    this.montTotAportAnioInmAnterior = string.Empty;
                else
                    this.montTotAportAnioInmAnterior = value;
            }
        }

        public string MontIntRealesDevengAnioInmAnt
        {
            get
            {
                return montIntRealesDevengAnioInmAnt;
            }
            set
            {
                if (value == null)
                    this.montIntRealesDevengAnioInmAnt = string.Empty;
                else
                    this.montIntRealesDevengAnioInmAnt = value;
            }
        }

        public string HuboRetirosAnioInmAntPer
        {
            get
            {
                return huboRetirosAnioInmAntPer;
            }
            set
            {
                if (value == null)
                    this.huboRetirosAnioInmAntPer = string.Empty;
                else
                    this.huboRetirosAnioInmAntPer = value;
            }
        }

        public string MontTotRetiradoAnioInmAntPer
        {
            get
            {
                return montTotRetiradoAnioInmAntPer;
            }
            set
            {
                if (value == null)
                    this.montTotRetiradoAnioInmAntPer = string.Empty;
                else
                    this.montTotRetiradoAnioInmAntPer = value;
            }
        }

        public string MontTotExentRetiradoAnioInmAnt
        {
            get
            {
                return montTotExentRetiradoAnioInmAnt;
            }
            set
            {
                if (value == null)
                    this.montTotExentRetiradoAnioInmAnt = string.Empty;
                else
                    this.montTotExentRetiradoAnioInmAnt = value;
            }
        }


        public string MontTotExedenteAnioInmAnt
        {
            get
            {
                return montTotExedenteAnioInmAnt;
            }
            set
            {
                if (value == null)
                    this.montTotExedenteAnioInmAnt = string.Empty;
                else
                    this.montTotExedenteAnioInmAnt = value;
            }
        }

        public string HuboRetirosAnioInmAnt
        {
            get
            {
                return huboRetirosAnioInmAnt;
            }
            set
            {
                if (value == null)
                    this.huboRetirosAnioInmAnt = string.Empty;
                else
                    this.huboRetirosAnioInmAnt = value;
            }
        }


        public string MontTotRetiradoAnioInmAnt
        {
            get
            {
                return montTotRetiradoAnioInmAnt;
            }
            set
            {
                if (value == null)
                    this.montTotRetiradoAnioInmAnt = string.Empty;
                else
                    this.montTotRetiradoAnioInmAnt = value;
            }
        }

        public string NumReferencia
        {
            get
            {
                return numReferencia;
            }
            set
            {
                if (value == null)
                    this.numReferencia = string.Empty;
                else
                    this.numReferencia = value;
            }
        }
    }
}
