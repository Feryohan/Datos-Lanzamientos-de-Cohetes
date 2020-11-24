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
        #region Atributos
        //Atributos Archivo 1
        double media1;
        double minimoValor1;
        double maximoValor1;
        double stdm1;
        string nombreDistribucion1;

        //Atributos Archivo 2
        double media2;
        double minimoValor2;
        double maximoValor2;
        double stdm2;
        string nombreDistribucion2;

        //Atributos Generales
        double minimoGlobal;
        double maximoGlobal;
        double paso;
        double[] arregloEjeX1;
        double[] arregloEjeX2;
        #endregion

        public Form2(double media1, double minimoValor1, double maximoValor1, double stdm1, string nombreArchivo1 ,double media2, double minimoValor2, double maximoValor2, double stdm2, string nombreArchivo2)
        {
            InitializeComponent();
            this.media1 = media1;
            this.minimoValor1 = minimoValor1;
            this.maximoValor1 = maximoValor1;
            this.stdm1 = stdm1;
            this.nombreDistribucion1 = nombreArchivo1;

            this.media2 = media2;
            this.minimoValor2 = minimoValor2;
            this.maximoValor2 = maximoValor2;
            this.stdm2 = stdm2;
            this.nombreDistribucion2 = nombreArchivo2;
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            
        }

        #region Botón: Paso
        private void btnPaso_Click(object sender, EventArgs e)
        {
            labelArchivo1.Text = "Probabilidad de " + nombreDistribucion1;
            labelArchivo2.Text = "Probabilidad de " + nombreDistribucion2;

            //Lectura del paso ingresado por el usuario
            paso = Convert.ToDouble(txtBoxPaso.Text);

            //Uso de Linspace 
            arregloEjeX1 = FuncionesEstadistica.Matlab.Linspace(minimoValor1, maximoValor1, paso).ToArray();
            arregloEjeX2 = FuncionesEstadistica.Matlab.Linspace(minimoValor2, maximoValor2, paso).ToArray();

            //Agregar los valores de arregloEjeX1 a los dos cmbEjeX1
            for (int i = 0; i<= arregloEjeX1.Length - 1; i++)
            {
                cmbEjeX1_A.Items.Add(Math.Round(arregloEjeX1[i],2));
                cmbEjeX1_B.Items.Add(Math.Round(arregloEjeX1[i], 2));
            }


            //Agregar los valores de arregloEjeX2 a los dos cmbEjeX2
            for (int i = 0; i <= arregloEjeX2.Length - 1; i++)
            {
                cmbEjeX2_A.Items.Add(Math.Round(arregloEjeX2[i],2));
                cmbEjeX2_B.Items.Add(Math.Round(arregloEjeX2[i], 2));
            }

            //Uso de Normpdf
            double[] funcionDeDensidad1 = new double[arregloEjeX1.Length];
            funcionDeDensidad1 = FuncionesEstadistica.Matlab.Normpdf(arregloEjeX1, media1, stdm1);
            double[] funcionDeDensidad2 = new double[arregloEjeX2.Length];
            funcionDeDensidad2 = FuncionesEstadistica.Matlab.Normpdf(arregloEjeX2, media2, stdm2);

            //Construcción de la gráfica
            //El área de los rectángulos es cero
            var chart = chart2.ChartAreas[0];
            chart.AxisX.IntervalType = DateTimeIntervalType.Number;
            //Se pone nulo para que el numeros aparézcan en los ejes
            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "";

            chart.AxisY.LabelStyle.IsEndLabelVisible = true;

            //Definiendo al minimoGlobal
            if (minimoValor1 < minimoValor2)
            {
                minimoGlobal = minimoValor1;
            }
            else
            {
                minimoGlobal = minimoValor2;
            }

            //Definiendo al maximoGlobal
            if (maximoValor1 > maximoValor2)
            {
                maximoGlobal = maximoValor1;
            }
            else
            {
                maximoGlobal = maximoValor2;
            }

            //Medidas del área para graficar
            chart.AxisX.Minimum = minimoGlobal;
            chart.AxisX.Maximum = maximoGlobal;
            chart.AxisX.Interval = 30;

            chart.AxisY.Minimum = 0;
            chart.AxisY.Maximum = 0.05;
            chart.AxisY.Interval = 0.01;

            //Diseño de la gráfica del archivo 1
            chart2.Series.Add("Archivo1");
            chart2.Series["Archivo1"].ChartType = SeriesChartType.Line;
            chart2.Series["Archivo1"].Color = Color.Blue;
            chart2.Series["Archivo1"].IsVisibleInLegend = false;

            for (int i = 0; i <= arregloEjeX1.Length - 1; i++)
            {
                chart2.Series["Archivo1"].Points.AddXY(arregloEjeX1[i], funcionDeDensidad1[i]);
            }

            //Diseño de la gráfica del archivo 2
            chart2.Series.Add("Archivo2");
            chart2.Series["Archivo2"].ChartType = SeriesChartType.Line;
            chart2.Series["Archivo2"].Color = Color.Red;
            chart2.Series["Archivo2"].IsVisibleInLegend = false;

            for (int i = 0; i <= arregloEjeX2.Length - 1; i++)
            {
                chart2.Series["Archivo2"].Points.AddXY(arregloEjeX2[i], funcionDeDensidad2[i]);
            }

        }
        #endregion

        #region Botón: Calcular probabilidad del archivo 1
        private void btnProArchivo1_Click(object sender, EventArgs e)
        {
            //Indices obtenidos de los valores seleccionados en el comboBox
            int indiceEjeX1_A = cmbEjeX1_A.SelectedIndex;
            int indiceEjeX1_B = cmbEjeX1_B.SelectedIndex;

            double valorA = arregloEjeX1[indiceEjeX1_A];
            double valorB = arregloEjeX1[indiceEjeX1_B];

            double[] funcionDeDensidad1 = new double[arregloEjeX1.Length];
            funcionDeDensidad1 = FuncionesEstadistica.Matlab.Normpdf(arregloEjeX1, media1, stdm1);

            //Cálculo de la probabilidad usando el método del Trapecio
            double probabilidad = FuncionesEstadistica.Matlab.RectanZ(arregloEjeX1, funcionDeDensidad1, valorA, valorB, paso);
            //Mostrando la probabilidad
            txtBoxProbabilidad1.Text = Convert.ToString(probabilidad);

            //Graficar el área de la probabilidad
            chart2.Series.Add("Probabilidad1");
            chart2.Series["Probabilidad1"].ChartType = SeriesChartType.Area;
            chart2.Series["Probabilidad1"].Color = Color.Blue;
            chart2.Series["Probabilidad1"].IsVisibleInLegend = false;

            for (int i = indiceEjeX1_A; i <= indiceEjeX1_B; i++)
            {
                chart2.Series["Probabilidad1"].Points.AddXY(arregloEjeX1[i], funcionDeDensidad1[i]);
            }
        }
        #endregion

        #region Botón: Calcular probabilidad del archivo 2
        private void btnProArchivo2_Click(object sender, EventArgs e)
        {
            //Indices obtenidos de los valores seleccionados en el comboBox
            int indiceEjeX2_A = cmbEjeX2_A.SelectedIndex;
            int indiceEjeX2_B = cmbEjeX2_B.SelectedIndex;

            double valorA = arregloEjeX2[indiceEjeX2_A];
            double valorB = arregloEjeX2[indiceEjeX2_B];

            double[] funcionDeDensidad2 = new double[arregloEjeX2.Length];
            funcionDeDensidad2 = FuncionesEstadistica.Matlab.Normpdf(arregloEjeX2, media2, stdm2);

            //Cálculo de la probabilidad usando el método del Trapecio
            double probabilidad = FuncionesEstadistica.Matlab.RectanZ(arregloEjeX2, funcionDeDensidad2, valorA, valorB, paso);

            //Mostrando la probabilidad 
            txtBoxProbabilidad2.Text = Convert.ToString(probabilidad);

            //Graficar el área de la probabilidad
            chart2.Series.Add("Probabilidad2");
            chart2.Series["Probabilidad2"].ChartType = SeriesChartType.Area;
            chart2.Series["Probabilidad2"].Color = Color.Red;
            chart2.Series["Probabilidad2"].IsVisibleInLegend = false;

            for (int i = indiceEjeX2_A; i <= indiceEjeX2_B; i++)
            {
                chart2.Series["Probabilidad2"].Points.AddXY(arregloEjeX2[i], funcionDeDensidad2[i]);
            }

        }
        #endregion

        #region Botón: Analizar Likelihood
        private void buttonAnalizarLikeli_Click(object sender, EventArgs e)
        {
            double[] valorAnalizar = new double[1];
            valorAnalizar[0] = Convert.ToDouble(txtBoxPuntoAnalizar.Text);
            double[] likeli1 = FuncionesEstadistica.Matlab.Normpdf(valorAnalizar, media1, stdm1);
            double[] likeli2 = FuncionesEstadistica.Matlab.Normpdf(valorAnalizar, media2, stdm2);

            txtBoxLikeli1.Text = Convert.ToString(likeli1[0]);
            labelLikeli1.Text = "Likelihood: " + nombreDistribucion1;
            txtBoxLikeli2.Text = Convert.ToString(likeli2[0]);
            labelLikeli2.Text = "Likelihood: " + nombreDistribucion2;

            if (likeli1[0] > likeli2[0])
            {
                txtBoxPertenece.Text = nombreDistribucion1;
            }
            else
            {
                txtBoxPertenece.Text = nombreDistribucion2;
            }
        }
        #endregion
    }
}
