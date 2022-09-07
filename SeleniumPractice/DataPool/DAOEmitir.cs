using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Excel;
using SeleniumPractice.Entities;
namespace SeleniumPractice.DataPool
{
    public class DAOEmitir
    {
        public List<EntComprobante> obtenerComprobantesExcel(string path)
        {
            List<EntComprobante> lstComprobantes = new List<EntComprobante>();
            FileStream stream = File.Open(path, FileMode.Open, FileAccess.Read);
            IExcelDataReader exec = ExcelReaderFactory.CreateOpenXmlReader(stream);
            exec.IsFirstRowAsColumnNames = true;
            DataSet resultado = exec.AsDataSet();
            foreach (DataRow _row in resultado.Tables["Comprobantes"].Rows)
            {
                lstComprobantes.Add(EntComprobante.Init(
                    Convert.ToString(_row["TipoDoc"]),
                    Convert.ToString(_row["Expedicion"]),
                    Convert.ToString(_row["Moneda"]),
                    Convert.ToString(_row["Serie"]),
                    Convert.ToString(_row["FormaPago"]),
                    Convert.ToString(_row["MetodoPago"]),
                    Emisor.Init(Convert.ToString(_row["RFCEmi"])),
                    Receptor.Init(Convert.ToString(_row["RFCReceptor"]),
                    Convert.ToString(_row["UsoCFDI"]),
                    Convert.ToString(_row["Nombre"]),
                    Convert.ToString(_row["Residencia"]),
                    Convert.ToString(_row["IDTributario"])
                        ),
                    Concepto.Init(Convert.ToString(_row["ClaveProducto"]),
                    Convert.ToString(_row["Unidad"]),
                    Convert.ToString(_row["NumIdentificacion"]),
                    Convert.ToString(_row["ClaveUnidad"]),
                    Convert.ToString(_row["Descripcion"]),
                    Convert.ToString(_row["Cantidad"]),
                    Convert.ToString(_row["ValorUnitario"]),
                    Convert.ToString(_row["Descuento"])),
                    AddComplemto(resultado),
                    AddNomina(resultado),
                    AddCombustible(resultado),
                    AddComercio(resultado),
                    AddHidrocarburo(resultado),
                    AddRetenciones(resultado)
                    ));
            }

            exec.Close();
            exec.Dispose();
            return lstComprobantes;
        }

        public List<ComplementoPago> obtenerComplementosPago(string path)
        {
            List<ComplementoPago> lstComplemento = new List<ComplementoPago>();
            FileStream stream = File.Open(path, FileMode.Open, FileAccess.Read);
            IExcelDataReader exec = ExcelReaderFactory.CreateOpenXmlReader(stream);
            exec.IsFirstRowAsColumnNames = true;
            DataSet resultado = exec.AsDataSet();

            foreach (DataRow _row in resultado.Tables["RecepcionPago"].Rows)
            {
                lstComplemento.Add(ComplementoPago.Init(
                         Convert.ToString(_row["FechaPago"]),
                                 Convert.ToString(_row["FormaPago"]),
                                 Convert.ToString(_row["NumIdenti"]),
                                 Convert.ToString(_row["Monto"]),
                                 Convert.ToString(_row["IdDocumento"]),
                                 Convert.ToString(_row["Parcialidad"]),
                                 Convert.ToString(_row["SaldoAnterior"]),
                                 Convert.ToString(_row["ImportePagado"]),
                                 Convert.ToString(_row["ImporteInsoluto"])
                    ));
            }

            exec.Close();
            exec.Dispose();
            return lstComplemento;
        }

        public ComplementoPago AddComplemto(DataSet resultado)
        {
            DataRow _row = resultado.Tables["RecepcionPago"].Rows[0];
            return ComplementoPago.Init(Convert.ToString(_row["FechaPago"]),
                                 Convert.ToString(_row["FormaPago"]),
                                 Convert.ToString(_row["NumIdenti"]),
                                 Convert.ToString(_row["Monto"]),
                                 Convert.ToString(_row["IdDocumento"]),
                                 Convert.ToString(_row["Parcialidad"]),
                                 Convert.ToString(_row["SaldoAnterior"]),
                                 Convert.ToString(_row["ImportePagado"]),
                                 Convert.ToString(_row["ImporteInsoluto"])

                );

        }


        public Nomina AddNomina(DataSet resultado)
        {
            DataRow _row = resultado.Tables["Nomina"].Rows[0];
            return Nomina.Init(
                Convert.ToString(_row["FechaPago"]),
                Convert.ToString(_row["FechaInicio"]),
                Convert.ToString(_row["FechaFinal"]),
                Convert.ToString(_row["FechaContrato"]),
                Convert.ToString(_row["NumDias"]),
                Convert.ToString(_row["Registro"]),
                Convert.ToString(_row["CURP"]),
                Convert.ToString(_row["SeguroSocial"]),
                Convert.ToString(_row["Anti"]),
                Convert.ToString(_row["TipoContrato"]),
                Convert.ToString(_row["Regimen"]),
                Convert.ToString(_row["Empleado"]),
                Convert.ToString(_row["Departamento"]),
                Convert.ToString(_row["RiesgoPuesto"]),
                Convert.ToString(_row["PeriodoPago"]),
                Convert.ToString(_row["Salario"]),
                Convert.ToString(_row["Entidad"]),
                Convert.ToString(_row["Porcentaje"]),
                Convert.ToString(_row["RFCLabora"]),
                Convert.ToString(_row["Percepcion"]),
                Convert.ToString(_row["ClavePercepcion"]),
                Convert.ToString(_row["Concepto"]),
                Convert.ToString(_row["ImporteGravado"]),
                Convert.ToString(_row["ImporteExento"])
                );
        }

        public Combustible AddCombustible(DataSet resultado)
        {
            DataRow _row = resultado.Tables["Combustible"].Rows[0];
            return Combustible.Init(
                Convert.ToString(_row["NumeroCuenta"]),
                Convert.ToString(_row["IdCombustible"]),
                Convert.ToString(_row["CombustibleFecha"]),
                Convert.ToString(_row["RFCCombustible"]),
                Convert.ToString(_row["ClaveEstacion"]),
                Convert.ToString(_row["Cantidad"]),
                Convert.ToString(_row["Nombre"]),
                Convert.ToString(_row["Folio"]),
                Convert.ToString(_row["Valor"]),
                Convert.ToString(_row["Importe"]),
                Convert.ToString(_row["Tasa"]),
                Convert.ToString(_row["TrasladoImporte"])
                );
        }


        public ComercioExterior AddComercio(DataSet resultado)
        {
            DataRow _row = resultado.Tables["Comercio"].Rows[0];
            return ComercioExterior.Init(
                 Convert.ToString(_row["NoIdentificacion"]),
                 Convert.ToString(_row["FraccionArancel"]),
                 Convert.ToString(_row["CantidadAduana"]),
                 Convert.ToString(_row["UnitarioAduana"]),
                 Convert.ToString(_row["ValorDolares"])
                );
        }

        public Hidrocarburos AddHidrocarburo(DataSet resultado)
        {
            DataRow _row = resultado.Tables["Hidrocarburos"].Rows[0];
            return Hidrocarburos.Init(
                Convert.ToString(_row["NumContrato"]),
                Convert.ToString(_row["Monto"]),
                Convert.ToString(_row["Porcentaje"]),
                Convert.ToString(_row["ErogacionOrigen"]),
                Convert.ToString(_row["Total"]),
                Convert.ToString(_row["ErogacionMes"])
                );
        }

        public Retenciones AddRetenciones(DataSet resultado)
        {
            DataRow _row = resultado.Tables["Retencion"].Rows[0];
            return Retenciones.Init(
                Convert.ToString(_row["FolioInterno"]),
                Convert.ToString(_row["TipoDocumento"]),
                Convert.ToString(_row["Retencion"]),
                Convert.ToString(_row["MesInicial"]),
                Convert.ToString(_row["MesFinal"]),
                Convert.ToString(_row["AnioEjercicio"]),
                Convert.ToString(_row["Total"]),
                Convert.ToString(_row["Gravable"]),
                Convert.ToString(_row["Exento"]),
                AddPlanesRetiro(resultado)
                );
        }

        public PlanRetiro AddPlanesRetiro(DataSet resultado)
        {
            DataRow _row = resultado.Tables["PlanRetiro"].Rows[0];
            return PlanRetiro.Init(
                    Convert.ToString(_row["Sistema"]),
                    Convert.ToString(_row["MontTotAporte"]),
                    Convert.ToString(_row["MonIntReales"]),
                    Convert.ToString(_row["HuboRetiros"]),
                    Convert.ToString(_row["MontRetiradoAnio"]),
                    Convert.ToString(_row["MontToExento"]),
                    Convert.ToString(_row["MontTotExedente"]),
                    Convert.ToString(_row["HuboRetirosAnioInmAnt"]),
                    Convert.ToString(_row["MontTotAnionte"]),
                    Convert.ToString(_row["Num"])
                );
        }
    }
}
