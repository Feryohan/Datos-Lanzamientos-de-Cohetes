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
        private string path = @"C:\Users\SERGIO ROMO\Documents\Semestre 2021-1\Temas Selectos de Programación\Lanzamientos Espaciales Exitosos\50datosdelanzamientosexitosos.xlsx";

        public Form1()
        {
            InitializeComponent();
        }


        //Método cuando la pantalla se carga
        private void Form1_Load(object sender, EventArgs e)
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
            chart.AxisX.Minimum = 1970;
            chart.AxisX.Maximum = 2019;
            chart.AxisX.Interval = 1;

            chart.AxisY.Minimum = 0;
            chart.AxisY.Maximum = 130;
            chart.AxisY.Interval = 10;

            //Diseño de la gráfica
            chart1.Series.Add("Lanzamientos");
            chart1.Series["Lanzamientos"].ChartType = SeriesChartType.Line;
            chart1.Series["Lanzamientos"].Color = Color.Purple;
            chart1.Series["Lanzamientos"].IsVisibleInLegend = false;



            //Creando nuevo objeto que recibe el path donde se encuentra el excel
            SLDocument sl = new SLDocument(path);

            //Los arreglos comienzan en cero
            //Las filas comienzan en uno

            //El indice, para la fila, empieza en el dos
            int iRow = 2;

            int año;

            //Creación de la lista
            List<LanzamientosViewModel> lstLanzamiento = new List<LanzamientosViewModel>();

            //Creación del arreglo 
            int[] arregloLanzamientos = new int[50];

            //El ciclo while se aplica hasta que no se encuentre un registro vacío
            //fila/columna
            while (!string.IsNullOrEmpty(sl.GetCellValueAsString(iRow,1)))
            {
                //Creación del apuntador
                LanzamientosViewModel oLanzamiento = new LanzamientosViewModel();
                oLanzamiento.Año = sl.GetCellValueAsString(iRow,1);
                oLanzamiento.LanzamientosOrbitalesExitosos = sl.GetCellValueAsInt32(iRow, 2);

                año = iRow + 1968;

                chart1.Series["Lanzamientos"].Points.AddXY(año, sl.GetCellValueAsInt32(iRow,2));

                //Se añade al arreglo
                arregloLanzamientos[iRow-2] = oLanzamiento.LanzamientosOrbitalesExitosos;

                //Se añaden a la lista
                lstLanzamiento.Add(oLanzamiento);

                iRow++;
            }

            //Haciendo que la lista aparezca en la pantalla
            dataGridView1.DataSource = lstLanzamiento;

            //Calculando el promedio
            double suma = 0;
            //For que recorre todos los elementos del arreglo
            foreach(var lanzamiento in arregloLanzamientos)
            {
                suma += lanzamiento;
            }

            double promedio = suma / arregloLanzamientos.Length;

            txtBoxPromedio.Text = Convert.ToString(promedio);

            //Obteniendo el valor máximo y mínimo
            int min;
            int max;

            min = max = arregloLanzamientos[0];

            for (int i = 0; i < 49; i++)
            {
                if (min > arregloLanzamientos[i])
                {
                    min = arregloLanzamientos[i];
                }
                if (max < arregloLanzamientos[i])
                {
                    max = arregloLanzamientos[i];
                }
            }

            txtBoxMax.Text = Convert.ToString(max);
            txtBoxMin.Text = Convert.ToString(min);

        }
    }
}
