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
    public partial class Form2 : Form
    {
        //Atributos
        double media;
        double minimoValor;
        double maximoValor;
        double stdp;
        double[] arregloEjeX = new double[50];
        double[] funcionDeDensidad = new double[50];


        public Form2(double media, double minimoValor, double maximoValor, double stdp)
        {
            InitializeComponent();
            this.media = media;
            this.minimoValor = minimoValor;
            this.maximoValor = maximoValor;
            this.stdp = stdp;
        }

        private void Form2_Shown(object sender, EventArgs e)
        {

            arregloEjeX = FuncionesEstadistica.Matlab3.Linspace(minimoValor, maximoValor, 50);
            funcionDeDensidad = FuncionesEstadistica.Matlab3.Normpdf(arregloEjeX, media, stdp);

            //Construcción de la gráfica
            //El área de los rectángulos es cero
            var chart = chart2.ChartAreas[0];
            chart.AxisX.IntervalType = DateTimeIntervalType.Number;
            //Se pone nulo para que el numeros aparézcan en los ejes
            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "";

            chart.AxisY.LabelStyle.IsEndLabelVisible = true;

            //Medidas del gráfico
            chart.AxisX.Minimum = minimoValor;
            chart.AxisX.Maximum = maximoValor;
            chart.AxisX.Interval = 10;

            chart.AxisY.Minimum = 0;
            chart.AxisY.Maximum = 0.04;
            chart.AxisY.Interval = 0.01;

            //Diseño de la gráfica
            chart2.Series.Add("FuncionDensidad");
            chart2.Series["FuncionDensidad"].ChartType = SeriesChartType.Line;
            chart2.Series["FuncionDensidad"].Color = Color.Purple;
            chart2.Series["FuncionDensidad"].IsVisibleInLegend = false;

            for(int i = 0; i<=arregloEjeX.Length-1; i++)
            {
                chart2.Series["FuncionDensidad"].Points.AddXY(arregloEjeX[i], funcionDeDensidad[i]);
            }
        }
    }
}
