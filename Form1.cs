using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Libreria para el chart
using System.Windows.Forms.DataVisualization.Charting;

namespace Lanzamientos_Espaciales_Exitosos
{
    public partial class Form1 : Form
    {
        #region Apuntadores
        //Apuntador
        Datos_Propiedades Archivo1 = new Datos_Propiedades();
        Datos_Propiedades Archivo2 = new Datos_Propiedades();
        #endregion

        //Página para descargar íconos gratis
        //https://iconarchive.com/

        public Form1()
        {
            InitializeComponent();
        }

        #region ListGridView
        //Método que muestra una tabla con los datos importados de Excel
        public void ListGridView(string rutaArchivo)
        {
            //Creando nuevo objeto SLDocument que recibe el path donde se encuentra el Excel
            SLDocument sl = new SLDocument(rutaArchivo);

            //Los arreglos comienzan en cero
            //Las filas comienzan en uno

            //El indice, para la fila, empieza en el dos
            int iRow = 2;

            //Creación de la lista para mostrar la tabla de datos Excel
            List<ExcelViewModel> lstExcelDatos = new List<ExcelViewModel>();
            
            //El ciclo while se aplica hasta que no se encuentre un registro vacío
            //fila/columna
            while (!string.IsNullOrEmpty(sl.GetCellValueAsString(iRow, 1)))
            {
                //Creación del apuntador
                ExcelViewModel apuntadorExcel = new ExcelViewModel();
                apuntadorExcel.SerVivo = sl.GetCellValueAsString(iRow, 1);
                apuntadorExcel.Altura_centimetros = sl.GetCellValueAsInt32(iRow, 2);

                //Se añaden a la lista los datos del Excel
                lstExcelDatos.Add(apuntadorExcel);

                iRow++;
            }
            //Haciendo que la lista aparezca en la pantalla
            dataGridView1.DataSource = lstExcelDatos;
        }
        #endregion

        #region LecturaExcel
        //Método que lee los datos del archivo de Excel y los guarda en una lista
        public static List<double> LecturaExcel(string rutaArchivo)
        {
            //Creando nuevo objeto SLDocument que recibe el path donde se encuentra el Excel
            SLDocument sl = new SLDocument(rutaArchivo);

                            //Los arreglos comienzan en cero
                            //Las filas comienzan en uno

            //El indice, para la fila, empieza en el dos
            int iRow = 2;

            //Creación de la lista para leer las alturas
            List<double> lstLectuaExcel = new List<double>();
            
            //El ciclo while se aplica hasta que no se encuentre un registro vacío
                                                                //fila/columna
            while (!string.IsNullOrEmpty(sl.GetCellValueAsString(iRow, 1)))
            {
                lstLectuaExcel.Add(sl.GetCellValueAsInt32(iRow, 2));

                iRow++;
            }

            return lstLectuaExcel;

        }
        #endregion

        #region Gráfica
        //Construcción de la gráfica
        public void Grafica(double[] datos, string nombreSerie, double minimoValor, double maximoValor, double promedio, double desviacionEstandar)
        {
            //El área de los rectángulos es cero
            var chart = chart1.ChartAreas[0];
            chart.AxisX.IntervalType = DateTimeIntervalType.Number;
            //Se pone nulo para que el numeros aparézcan en los ejes
            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "";

            chart.AxisY.LabelStyle.IsEndLabelVisible = true;

            //Medidas del gráfico
            chart.AxisX.Minimum = 1;
            chart.AxisX.Maximum = 50;
            chart.AxisX.Interval = 10;

            chart.AxisY.Minimum = minimoValor;
            chart.AxisY.Maximum = maximoValor;
            chart.AxisY.Interval = 10;

            //Diseño de la gráfica
            chart1.Series.Add(nombreSerie);
            chart1.Series[nombreSerie].ChartType = SeriesChartType.Line;
            chart1.Series[nombreSerie].Color = Color.Purple;
            chart1.Series[nombreSerie].IsVisibleInLegend = false;

            //Imprimiendo los puntos de la gráfica
            for (int i = 0; i <= datos.Length - 1; i++)
            {
                chart1.Series[nombreSerie].Points.AddXY(i + 1, datos[i]);
            }

            //Imprimiendo la línea de promedio
            chart1.Series.Add(nombreSerie+"promedio");
            chart1.Series[nombreSerie + "promedio"].ChartType = SeriesChartType.Line;
            chart1.Series[nombreSerie + "promedio"].Color = Color.Red;
            chart1.Series[nombreSerie + "promedio"].IsVisibleInLegend = false;
            for (int i = 1; i <= datos.Length; i++)
            {
                chart1.Series[nombreSerie + "promedio"].Points.AddXY(i, promedio);
            }

            //Imprimiendo la desviacion estandar hacía arriba
            for (int i = 1; i < 5; i++)
            {
                string serie = "DesviacionArriba" + Convert.ToString(i) + " " + nombreSerie;
                chart1.Series.Add(serie);
                chart1.Series[serie].ChartType = SeriesChartType.Line;
                chart1.Series[serie].Color = Color.Blue;
                chart1.Series[serie].IsVisibleInLegend = false;

                double posicion = promedio + (desviacionEstandar * i);
                int alumno = 1;
                for (int j = 0; j < datos.Length; j++)
                {
                    chart1.Series[serie].Points.AddXY(alumno + j, posicion);
                }
            }

            //Imprimiendo la desviacion estandar hacía abajo
            for (int i = 1; i < 5; i++)
            {
                string serie = "DesviacionAbajo" + Convert.ToString(i) + " " + nombreSerie;
                chart1.Series.Add(serie);
                chart1.Series[serie].ChartType = SeriesChartType.Line;
                chart1.Series[serie].Color = Color.Green;
                chart1.Series[serie].IsVisibleInLegend = false;

                double posicion = promedio - (desviacionEstandar * i);
                int alumno = 1;
                for (int j = 0; j < datos.Length; j++)
                {
                    chart1.Series[serie].Points.AddXY(alumno + j, posicion);
                }
            }
        }

        #endregion

        #region Botón: Buscar1
        private void btnBuscar1_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            Archivo1.rutaArchivo = string.Empty;
            Archivo1.nombreDatos = "Boton1";

            //OpenFileDialog permite abrir el buscador de archivos
            OpenFileDialog openFileDialog = new OpenFileDialog();

            //Si el usuario sí abre un archivo, el if se ejecuta
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Archivo1.rutaArchivo = openFileDialog.FileName;
                ListGridView(Archivo1.rutaArchivo);
                Archivo1.alturas = LecturaExcel(Archivo1.rutaArchivo).ToArray();

                //Método para obtener el nombre del archivo
                string[] nombre = Archivo1.rutaArchivo.Split('\\','.');
                Archivo1.nombreDatos = nombre[nombre.Length - 2];

                #region Datos mostrados en Form1
                //Mostrando Promedio
                Archivo1.promedio = FuncionesEstadistica.Matlab.Mean(Archivo1.alturas);
                txtBoxPromedio.Text = Convert.ToString(Archivo1.promedio);

                //Mostrando Varianza
                txtBoxVarianza.Text = Convert.ToString(Math.Round(FuncionesEstadistica.Matlab.VarM(Archivo1.alturas), 4));

                //Mostrando Desviación Estandar
                Archivo1.desviacionEstandar = FuncionesEstadistica.Matlab.StdM(Archivo1.alturas);
                txtBoxSTD.Text = Convert.ToString(Math.Round(Archivo1.desviacionEstandar));
                
                //Desviaciones estandar sobre el promedio
                txtBoxDEP1Arriba.Text = Convert.ToString(Math.Round(Archivo1.promedio + Archivo1.desviacionEstandar, 4));
                txtBoxDEP2Arriba.Text = Convert.ToString(Math.Round(Archivo1.promedio + (2 * Archivo1.desviacionEstandar), 4));
                txtBoxDEP3Arriba.Text = Convert.ToString(Math.Round(Archivo1.promedio + (3 * Archivo1.desviacionEstandar), 4));
                txtBoxDEP4Arriba.Text = Convert.ToString(Math.Round(Archivo1.promedio + (4 * Archivo1.desviacionEstandar), 4));

                //Desviaciones estandar bajo el promedio
                txtBoxDEP1Abajo.Text = Convert.ToString(Math.Round(Archivo1.promedio - Archivo1.desviacionEstandar, 4));
                txtBoxDEP2Abajo.Text = Convert.ToString(Math.Round(Archivo1.promedio - (2 * Archivo1.desviacionEstandar), 4));
                txtBoxDEP3Abajo.Text = Convert.ToString(Math.Round(Archivo1.promedio - (3 * Archivo1.desviacionEstandar), 4));
                txtBoxDEP4Abajo.Text = Convert.ToString(Math.Round(Archivo1.promedio - (4 * Archivo1.desviacionEstandar), 4));

                //Valor máximo de la función de densidad
                Archivo1.maxValFunDensi = Archivo1.promedio + (4 * Archivo1.desviacionEstandar);
                //Máximo valor de los 50 datos
                txtBoxMax.Text = Convert.ToString(FuncionesEstadistica.Matlab.Max(Archivo1.alturas));

                //Valor mínimo de la función de densidad
                Archivo1.minValFunDensi = Archivo1.promedio - (4 * Archivo1.desviacionEstandar);
                //Mínimo valor de los 50 datos 
                txtBoxMin.Text = Convert.ToString(FuncionesEstadistica.Matlab.Min(Archivo1.alturas));
                #endregion

                //Graficando
                Grafica(Archivo1.alturas, Archivo1.nombreDatos, Archivo1.minValFunDensi, Archivo1.maxValFunDensi, Archivo1.promedio, Archivo1.desviacionEstandar);
            }

            txtBuscar1.Text = Archivo1.nombreDatos;
        }
        #endregion

        #region Botón: Buscar2
        private void btnBuscar2_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            Archivo2.rutaArchivo = string.Empty;
            Archivo2.nombreDatos = "Boton2";

            //OpenFileDialog permite abrir el buscador de archivos
            OpenFileDialog openFileDialog = new OpenFileDialog();

            //Si el usuario sí abre un archivo, el if se ejecuta
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Archivo2.rutaArchivo = openFileDialog.FileName;
                ListGridView(Archivo2.rutaArchivo);
                Archivo2.alturas = LecturaExcel(Archivo2.rutaArchivo).ToArray();

                //Método para obtener el nombre del archivo
                string[] nombre = Archivo2.rutaArchivo.Split('\\','.');
                Archivo2.nombreDatos = nombre[nombre.Length - 2];

                #region Datos mostrados en Form1
                //Mostrando Promedio
                Archivo2.promedio = FuncionesEstadistica.Matlab.Mean(Archivo2.alturas);
                txtBoxPromedio.Text = Convert.ToString(Archivo2.promedio);

                //Mostrando Varianza
                txtBoxVarianza.Text = Convert.ToString(Math.Round(FuncionesEstadistica.Matlab.VarM(Archivo2.alturas), 4));

                //Mostrando Desviación Estandar
                Archivo2.desviacionEstandar = FuncionesEstadistica.Matlab.StdM(Archivo2.alturas);
                txtBoxSTD.Text = Convert.ToString(Math.Round(Archivo2.desviacionEstandar));

                //Desviaciones estandar sobre el promedio
                txtBoxDEP1Arriba.Text = Convert.ToString(Math.Round(Archivo2.promedio + Archivo2.desviacionEstandar, 4));
                txtBoxDEP2Arriba.Text = Convert.ToString(Math.Round(Archivo2.promedio + (2 * Archivo2.desviacionEstandar), 4));
                txtBoxDEP3Arriba.Text = Convert.ToString(Math.Round(Archivo2.promedio + (3 * Archivo2.desviacionEstandar), 4));
                txtBoxDEP4Arriba.Text = Convert.ToString(Math.Round(Archivo2.promedio + (4 * Archivo2.desviacionEstandar), 4));

                //Desviaciones estandar bajo el promedio
                txtBoxDEP1Abajo.Text = Convert.ToString(Math.Round(Archivo2.promedio - Archivo2.desviacionEstandar, 4));
                txtBoxDEP2Abajo.Text = Convert.ToString(Math.Round(Archivo2.promedio - (2 * Archivo2.desviacionEstandar), 4));
                txtBoxDEP3Abajo.Text = Convert.ToString(Math.Round(Archivo2.promedio - (3 * Archivo2.desviacionEstandar), 4));
                txtBoxDEP4Abajo.Text = Convert.ToString(Math.Round(Archivo2.promedio - (4 * Archivo2.desviacionEstandar), 4));

                //Valor máximo de la función de densidad
                Archivo2.maxValFunDensi = Archivo2.promedio + (4 * Archivo2.desviacionEstandar);
                //Máximo valor de los 50 datos
                txtBoxMax.Text = Convert.ToString(FuncionesEstadistica.Matlab.Max(Archivo2.alturas));

                //Valor mínimo de la función de densidad
                Archivo2.minValFunDensi = Archivo2.promedio - (4 * Archivo2.desviacionEstandar);
                //Mínimo valor de los 50 datos 
                txtBoxMin.Text = Convert.ToString(FuncionesEstadistica.Matlab.Min(Archivo2.alturas));
                #endregion

                //Graficando
                Grafica(Archivo2.alturas, Archivo2.nombreDatos, Archivo2.minValFunDensi, Archivo2.maxValFunDensi, Archivo2.promedio, Archivo2.desviacionEstandar);

            }
            txtBuscar2.Text = Archivo2.nombreDatos;

            btnFuncionDensidad.Visible = true;
        }
        #endregion

        //Método cuando la pantalla se carga
        public void Form1_Load(object sender, EventArgs e)
        {
            
        }

        #region Botón: Función de Densidad
        private void btnFuncionDensidad_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(Archivo1.promedio, Archivo1.minValFunDensi, Archivo1.maxValFunDensi, Archivo1.desviacionEstandar, Archivo1.nombreDatos, Archivo2.promedio, Archivo2.minValFunDensi, Archivo2.maxValFunDensi, Archivo2.desviacionEstandar, Archivo2.nombreDatos);
            form2.Show();
        }
        #endregion
    }
}
