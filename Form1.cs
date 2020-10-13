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
            //Creando nuevo objeto que recibe el path donde se encuentra el excel
            SLDocument sl = new SLDocument(path);

            //Los arreglos comienzan en cero
            //Las filas comienzan en uno

            //El indice, para la fila, empieza en el dos
            int iRow = 2;

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
        }
    }
}
