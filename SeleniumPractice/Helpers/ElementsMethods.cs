using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Globalization;
namespace SeleniumPractice.Helpers
{
    public class ElementsMethods
    {
        static List<TableDataCollection> tableColecction = new List<TableDataCollection>();

        public static void HoverElement(IWebDriver driver, IWebElement element)
        {
            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
        }
        public static void HoverElementAndClick(IWebDriver driver, IWebElement elementToHover, IWebElement elementToClick)
        {
            Actions action = new Actions(driver);
            action.MoveToElement(elementToHover).Click(elementToClick).Build().Perform();
        }

        public static void ScrollUp(IWebDriver driver)
        {
            //baja hasta el final de la página
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("window.scrollTo(0, 0)");
        }

        public static void ScrollDown(IWebDriver driver)
        {
            //baja hasta el final de la página
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
        }

        public static void ScrollModalWindow(IWebElement element, IWebDriver driver)
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            //baja el scroll hasta encontrar el elemento indicado
            executor.ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }

        public static void ClickJSMessage(IWebDriver driver)
        {
            IAlert alert = driver.SwitchTo().Alert();
            string text = alert.Text;
            alert.Accept();
        }



        public static string RandomRFC()
        {
            string letras = string.Empty;
            Random rand = new Random();
            int numero = 0;
            for (int i = 0; i < 3; i++)
            {
                numero = rand.Next(26);
                char letra = (char)(((int)'A') + numero);
                letras += letra;
            }

            letras += "9003172";
            numero = rand.Next(26);
            char letra2 = (char)(((int)'A') + numero);
            letras += letra2;
            letras += rand.Next(9).ToString();
            return letras;
        }

        public static void leerCalendario(IWebDriver tabla, int dia)
        {

            //obtener todos los encabezados columnas de la tabla
            var columns = tabla.FindElements(By.TagName("th"));
            //obtener todas las fila 
            var filas = tabla.FindElements(By.TagName("tr"));
            int flag = 0;
            for (int indexFila = 1; indexFila <= 6; indexFila++)
            {
                for (int colum = 1; colum <= 7; colum++)
                {
                    var celda = tabla.FindElement(By.CssSelector("tr:nth-child(" + indexFila + ") > .day:nth-child(" + colum + ")"));
                    if (celda.Text == dia.ToString())
                    {
                        celda.Click();
                        flag = 1;
                        break;
                    }

                }

                if (flag == 1)
                {
                    break;
                }

            }

        }
        public static void SeleccionarMes(IWebDriver tabla, int mesSel)
        {
            for (int mes = 1; mes <= 12; mes++)
            {
                var celda = tabla.FindElement(By.CssSelector(".month:nth-child(" + mes + ")"));
                if (mes == mesSel)
                {
                    celda.Click();
                    break;
                }
            }
        }

        public static void SeleccionaAnio(IWebDriver tabla, string anio)
        {
            for (int y = 1; y <= 12; y++)
            {
                var celda = tabla.FindElement(By.CssSelector(".year:nth-child(" + y + ")"));
                if (celda.Text == anio)
                {
                    celda.Click();
                    break;
                }

            }
        }

        public static void seleccionarFecha(IWebElement mes, IWebElement anio, IWebDriver driver, string fecha)
        {
            mes.Click();
            anio.Click();
            //DateTime fechaDate = fecha;
            DateTime dateTime = DateTime.Parse(fecha);
            fecha = dateTime.ToString("dd/MM/yyyy");
            string[] arregloFecha = SepararFecha(fecha);
            SeleccionaAnio(driver, arregloFecha[2]);
            SeleccionarMes(driver, Int32.Parse(arregloFecha[1]));
            leerCalendario(driver, Int32.Parse(arregloFecha[0]));
        }


        private static string[] SepararFecha(string fecha)
        {
            var splitFecha = fecha.Split('/');
            return splitFecha;
        }

        public static int[] SepararFechaCalendario(string fecha)
        {
            CultureInfo culture = new CultureInfo("es-ES");
            DateTime dateTime = DateTime.Parse(fecha);
            dateTime = dateTime.AddMonths(-1);
            //  DateTime date = DateTime.Parse(dateTime.ToString(), culture);
            fecha = dateTime.ToString("dd/MM/yyyy");
            var splitFecha = fecha.Split('/');
            int[] numero = Array.ConvertAll(splitFecha, int.Parse);

            return numero;
        }


        public static int[] SepararFechaCalendarioFinal(string fecha)
        {
            CultureInfo culture = new CultureInfo("es-ES");
            DateTime dateTime = DateTime.Parse(fecha);
            //dateTime = dateTime.AddMonths(-1);
            //  DateTime date = DateTime.Parse(dateTime.ToString(), culture);
            fecha = dateTime.ToString("dd/MM/yyyy");
            var splitFecha = fecha.Split('/');
            int[] numero = Array.ConvertAll(splitFecha, int.Parse);

            return numero;
        }

        public static void leerTablaCompleta(IWebElement tabla)
        {

            //obtener todos los encabezados columnas de la tabla
            var columns = tabla.FindElements(By.TagName("th"));
            //obtener todas las fila 
            var filas = tabla.FindElements(By.TagName("tr"));
            int indexFila = 0;
            //recorrer todas las filas y columnas de la tabla y agregarlas a la lista
            foreach (var fila in filas)
            {

                var colDatos = fila.FindElements(By.TagName("td"));
                int indexColumna = 0;
                foreach (var col in colDatos)
                {
                    tableColecction.Add(new TableDataCollection
                    {
                        numeroFila = indexFila,
                        nombreColumna = columns[indexColumna].Text,
                        valorColumna = col.Text,
                    }
                    );
                    indexColumna++;
                }
                indexFila++;
            }

        }





        public static void leerColumnaRFC(IWebElement tabla)
        {
            //obtener todos los encabezados columnas de la tabla
            var columns = tabla.FindElements(By.XPath("//th[1]"));
            //obtener todas las fila 
            var filas = tabla.FindElements(By.XPath("//tr//td[1]"));
            int indexFila = 1;
            //recorrer todas las filas y columnas de la tabla y agregarlas a la lista
            foreach (var fila in filas)
            {

                var colDatos = fila.FindElements(By.XPath("//td[1]"));

                tableColecction.Add(new TableDataCollection
                {
                    numeroFila = indexFila,
                    nombreColumna = columns[0].Text,
                    valorColumna = fila.Text,
                }
                );

                indexFila++;

            }

        }

        public static void leerColumnaFiltros(IWebElement tabla)
        {
            //obtener todos los encabezados columnas de la tabla
            var columns = tabla.FindElements(By.XPath("//th[1]"));
            //obtener todas las fila 
            var filas = tabla.FindElements(By.XPath("//tr//td[4]"));
            int indexFila = 1;
            //recorrer todas las filas y columnas de la tabla y agregarlas a la lista
            foreach (var fila in filas)
            {

                var colDatos = tabla.FindElement(By.XPath(" //*[@id='maincontent']/fieldset/table/tbody/tr[" + indexFila + "]/td[1]"));

                tableColecction.Add(new TableDataCollection
                {
                    numeroFila = indexFila,
                    nombreColumna = columns[0].Text,
                    valorColumna = colDatos.Text,
                }
                );
                indexFila++;
            }

        }


        public static void leerColumnaUsuarios(IWebElement tabla)
        {
            //obtener todos los encabezados columnas de la tabla
            // var columns = tabla.FindElements(By.ClassName("dxgvHeader"));
            //obtener todas las fila 
            var filas = tabla.FindElements(By.ClassName("dxgvDataRow"));
            int indexFila = 0;

            //recorrer todas las filas y columnas de la tabla y agregarlas a la lista
            foreach (var fila in filas)
            {
                var colDatos = fila.FindElements(By.ClassName("dxgv"));
                if (colDatos.Count == 0)
                {
                    break;
                }
                tableColecction.Add(new TableDataCollection
                {
                    numeroFila = indexFila,
                    nombreColumna = "Emisor",
                    valorColumna = colDatos[0].Text,
                }
                );
                indexFila++;

            }

        }


        public static void leerColumnaCFDI(IWebElement tabla)
        {

            //  var filas = tabla.FindElements(By.CssSelector("tr[class='dxgvDataRow']"));
            var numFilas = tabla.FindElements(By.XPath("/html/body/div[1]/div[2]/div/div[2]/form/fieldset/div[2]/table/tbody/tr/td/div[1]/table/tbody/tr/td[8]"));
            int indexFila = 0;
            //recorrer todas las filas y columnas de la tabla y agregarlas a la lista
            foreach (var fila in numFilas)
            {
                // var colDatos = fila.FindElements(By.ClassName("dxgv"));
                if (fila.Displayed)
                {
                    tableColecction.Add(new TableDataCollection
                    {
                        numeroFila = indexFila,
                        nombreColumna = "Emisor",
                        valorColumna = fila.Text,
                    }
                  );
                    indexFila++;
                }

            }

        }

        public static void leerColumnaPSECFDI(IWebElement tabla)
        {
            //  var filas = tabla.FindElements(By.CssSelector("tr[class='dxgvDataRow']"));
            var numFilas = tabla.FindElements(By.XPath("/html/body/div[1]/div[2]/div/div[2]/form/fieldset/div[2]/table/tbody/tr/td/div[1]/table/tbody/tr/td[7]"));
            int indexFila = 0;
            //recorrer todas las filas y columnas de la tabla y agregarlas a la lista
            foreach (var fila in numFilas)
            {
                // var colDatos = fila.FindElements(By.ClassName("dxgv"));
                if (fila.Displayed)
                {
                    tableColecction.Add(new TableDataCollection
                    {
                        numeroFila = indexFila,
                        nombreColumna = "Emisor",
                        valorColumna = fila.Text,
                    }
                  );
                    indexFila++;
                }

            }

        }

        public static void leerColumnaRetencion(IWebElement tabla)
        {
            //  var filas = tabla.FindElements(By.CssSelector("tr[class='dxgvDataRow']"));
            var numFilas = tabla.FindElements(By.XPath("/html/body/div[1]/div[2]/div/div[2]/form/fieldset/div[2]/table/tbody/tr/td/div[1]/table/tbody/tr/td[8]"));
            int indexFila = 0;
            //recorrer todas las filas y columnas de la tabla y agregarlas a la lista
            foreach (var fila in numFilas)
            {
                // var colDatos = fila.FindElements(By.ClassName("dxgv"));
                if (fila.Displayed)
                {
                    tableColecction.Add(new TableDataCollection
                    {
                        numeroFila = indexFila,
                        nombreColumna = "Emisor",
                        valorColumna = fila.Text,
                    }
                  );
                    indexFila++;
                }

            }

        }

        //Obtener el contenido de la celda de la tabla proporcionando fila y col
        public static string leerCelda(string nombreColumna, int numeroFila)
        {
            var datos = (from e in tableColecction
                         where e.nombreColumna == nombreColumna && e.numeroFila == numeroFila
                         select e.valorColumna).FirstOrDefault();

            return datos;
        }

        public static int devolverFilaRFC(string nombreColumna, string rfc)
        {
            var numFila = (from e in tableColecction
                           where e.nombreColumna == nombreColumna
                           && e.valorColumna == rfc
                           select e.numeroFila
                           ).FirstOrDefault();
            return numFila;
        }

        public static int devolverFilaComprobante(string nombreColumna, string rfc)
        {
            var numFila = (from e in tableColecction
                           where e.nombreColumna == nombreColumna
                           && e.valorColumna == rfc
                           select e.numeroFila
                           ).FirstOrDefault();
            return numFila;
        }

    }


    public class TableDataCollection
    {
        public int numeroFila { get; set; }
        public string nombreColumna { get; set; }
        public string valorColumna { get; set; }

    }

}
