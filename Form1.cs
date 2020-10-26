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


        //Página para descargar íconos gratis
        //https://iconarchive.com/

        //Ingresamos la dirección del archivo excel 
        private string path = @"C:\Users\SERGIO ROMO\Documents\Semestre 2021-1\Temas Selectos de Programación\Lanzamientos Espaciales Exitosos\50DatosDeCalificacionesCurso.xlsx";

        public Form1()
        {
            InitializeComponent();
            
        }


        //Método cuando la pantalla se carga
        public void Form1_Load(object sender, EventArgs e)
        {
            //Construcción de la gráfica
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

            chart.AxisY.Minimum = 0;
            chart.AxisY.Maximum = 100;
            chart.AxisY.Interval = 20;

            //Diseño de la gráfica
            chart1.Series.Add("Calificaciones");
            chart1.Series["Calificaciones"].ChartType = SeriesChartType.Line;
            chart1.Series["Calificaciones"].Color = Color.Purple;
            chart1.Series["Calificaciones"].IsVisibleInLegend = false;

            


            //Creando nuevo objeto que recibe el path donde se encuentra el excel
            SLDocument sl = new SLDocument(path);

            //Los arreglos comienzan en cero
            //Las filas comienzan en uno

            //El indice, para la fila, empieza en el dos
            int iRow = 2;

            int alumno;

            //Creación de la lista
            List<CalificacionesViewModel> lstCalificaciones = new List<CalificacionesViewModel>();

            //Creación del arreglo 
            int[] arregloCalificaciones = new int[50];

            //El ciclo while se aplica hasta que no se encuentre un registro vacío
            //fila/columna
            while (!string.IsNullOrEmpty(sl.GetCellValueAsString(iRow,1)))
            {
                //Creación del apuntador
                CalificacionesViewModel oCalificaciones = new CalificacionesViewModel();
                oCalificaciones.Estudiante = sl.GetCellValueAsString(iRow,1);
                oCalificaciones.CalificacionDelCurso = sl.GetCellValueAsInt32(iRow, 2);

                alumno = iRow -1;

                chart1.Series["Calificaciones"].Points.AddXY(alumno, sl.GetCellValueAsInt32(iRow,2));

                //Se añade al arreglo
                arregloCalificaciones[iRow-2] = oCalificaciones.CalificacionDelCurso;

                //Se añaden a la lista
                lstCalificaciones.Add(oCalificaciones);

                iRow++;
            }

            //Haciendo que la lista aparezca en la pantalla
            dataGridView1.DataSource = lstCalificaciones;

            //Mostrando Promedio
            txtBoxPromedio.Text = Convert.ToString(FuncionesEstadistica.Matlab1.Mean(arregloCalificaciones));
            double promedio = FuncionesEstadistica.Matlab1.Mean(arregloCalificaciones);
            //Mostrando Valor Maximo
            txtBoxMax.Text = Convert.ToString(FuncionesEstadistica.Matlab1.Max(arregloCalificaciones));
            double maximoValor = FuncionesEstadistica.Matlab1.Max(arregloCalificaciones);
            //Mostrando Valor Minimo
            txtBoxMin.Text = Convert.ToString(FuncionesEstadistica.Matlab1.Min(arregloCalificaciones));
            double minimoValor = FuncionesEstadistica.Matlab1.Min(arregloCalificaciones);
            //Mostrando Varianza
            txtBoxVarianza.Text = Convert.ToString(Math.Round(FuncionesEstadistica.Matlab2.VarP(arregloCalificaciones),4));
            //Mostrando Desviación Estandar
            txtBoxSTD.Text = Convert.ToString(Math.Round(FuncionesEstadistica.Matlab2.StdP(arregloCalificaciones),4));
            double stdp = FuncionesEstadistica.Matlab2.StdP(arregloCalificaciones);

            txtBoxDEP1Arriba.Text = Convert.ToString(Math.Round(promedio + stdp,4));
            txtBoxDEP2Arriba.Text = Convert.ToString(Math.Round(promedio + (2*stdp), 4));
            txtBoxDEP3Arriba.Text = Convert.ToString(Math.Round(promedio + (3 * stdp), 4));
            txtBoxDEP4Arriba.Text = Convert.ToString(Math.Round(promedio + (4 * stdp), 4));

            txtBoxDEP1Abajo.Text = Convert.ToString(Math.Round(promedio - stdp, 4));
            txtBoxDEP2Abajo.Text = Convert.ToString(Math.Round(promedio - (2 * stdp), 4));
            txtBoxDEP3Abajo.Text = Convert.ToString(Math.Round(promedio - (3 * stdp), 4));
            txtBoxDEP4Abajo.Text = Convert.ToString(Math.Round(promedio - (4 * stdp), 4));

            //Imprimiendo la línea de promedio
            chart1.Series.Add("Promedio");
            chart1.Series["Promedio"].ChartType = SeriesChartType.Line;
            chart1.Series["Promedio"].Color = Color.Red;
            chart1.Series["Promedio"].IsVisibleInLegend = false;
            alumno = 1970;
            for (int i = 0; i<arregloCalificaciones.Length; i++)
            {
                chart1.Series["Promedio"].Points.AddXY(alumno+i, promedio);
            }

            //Imprimiendo la desviacion estandar hacía arriba
            for (int i = 1; i < 5; i++)
            {
                string serie = "DesviacionArriba" + Convert.ToString(i);
                chart1.Series.Add(serie);
                chart1.Series[serie].ChartType = SeriesChartType.Line;
                chart1.Series[serie].Color = Color.Blue;
                chart1.Series[serie].IsVisibleInLegend = false;

                double posicion = promedio + (stdp * i);
                alumno = 1970;
                for (int j = 0; j < arregloCalificaciones.Length; j++)
                {
                    chart1.Series[serie].Points.AddXY(alumno + j, posicion);
                }
            }

            //Imprimiendo la desviacion estandar hacía abajo
            for (int i = 1; i < 5; i++)
            {
                string serie = "DesviacionAbajo" + Convert.ToString(i);
                chart1.Series.Add(serie);
                chart1.Series[serie].ChartType = SeriesChartType.Line;
                chart1.Series[serie].Color = Color.Green;
                chart1.Series[serie].IsVisibleInLegend = false;

                double posicion = promedio - (stdp * i);
                alumno = 1970;
                for (int j = 0; j < arregloCalificaciones.Length; j++)
                {
                    chart1.Series[serie].Points.AddXY(alumno + j, posicion);
                }
            }
        }
    }
}
