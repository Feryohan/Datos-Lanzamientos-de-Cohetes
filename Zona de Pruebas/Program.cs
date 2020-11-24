using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zona_de_Pruebas
{
    class Program
    {

        static void Main(string[] args)
        {
            //Dirección del documento de Excel
            string path;
            path = @"C:\Users\SERGIO ROMO\Documents\Semestre 2021-1\Temas Selectos de Programación\Lanzamientos Espaciales Exitosos\50DatosDeCalificacionesCurso.xlsx";

            //Libreria SpreadsheetLight version 3.4.9 instalada desde el NuGet
            //DocumentFormat.OpenXml version 2.5.0 instalada desde el NuGet
            SLDocument sl = new SLDocument(path);

            //Los arreglos comienzan en cero
            //Las filas comienzan en uno

            //El indice, para la fila, empieza en el dos
            int iRow = 2;

            //Creación del arreglo 
            int[] arregloCalificaciones = new int[50];

            //El ciclo while se aplica hasta que no se encuentre un registro vacío
                                                                //fila/columna
            while (!string.IsNullOrEmpty(sl.GetCellValueAsString(iRow, 2)))
            {
                //Se añade al arreglo
                arregloCalificaciones[iRow - 2] = sl.GetCellValueAsInt32(iRow, 2);

                //Se muestra en pantalla
                Console.WriteLine(arregloCalificaciones[iRow - 2]);

                iRow++;
            }

            //Se muestra la suma de los 50 datos
            Console.WriteLine("\n\nSUMA = " + FuncionesEstadistica.Matlab.Sum(arregloCalificaciones));

            //Se muestra el promedio de los 50 datos
            Console.WriteLine("\nPromedio = " + FuncionesEstadistica.Matlab.Mean(arregloCalificaciones));
            double media = FuncionesEstadistica.Matlab.Mean(arregloCalificaciones);

            //Se muestra el valor mínimo de los 50 datos
            Console.WriteLine("\nMínimo = " + FuncionesEstadistica.Matlab.Min(arregloCalificaciones));
            double minimo = FuncionesEstadistica.Matlab.Min(arregloCalificaciones);

            //Se muestra el valor máximo de los 50 datos
            Console.WriteLine("\nMáximo = " + FuncionesEstadistica.Matlab.Max(arregloCalificaciones));
            double maximo = FuncionesEstadistica.Matlab.Max(arregloCalificaciones);

            //Se muestra la varianza poblacional de los 50 datos
            Console.WriteLine("\nVarianza Poblacional = " + FuncionesEstadistica.Matlab.VarP(arregloCalificaciones));

            //Se muestra la desviación estandar poblacional de los 50 datos
            Console.WriteLine("\nDesviacion Estandar Poblacional = " + FuncionesEstadistica.Matlab.StdP(arregloCalificaciones));
            double desviacionE = FuncionesEstadistica.Matlab.StdP(arregloCalificaciones);

            //Se muestra la varianza muestral de los 50 datos
            Console.WriteLine("\nVarianza Muestral = " + FuncionesEstadistica.Matlab.VarM(arregloCalificaciones));

            //Se muestra la desviación estandar muestral de los 50 datos
            Console.WriteLine("\nDesviacion Estandar Muestra = " + FuncionesEstadistica.Matlab.StdM(arregloCalificaciones));

            //Lectura del paso que el usuario desea usar para generar el eje x
            Console.WriteLine("\n\n*** Ingrese el paso que desea utilizar: ***");
            double paso;
            paso = Convert.ToDouble(Console.ReadLine());

            //Obteniendo el arreglo de puntos del EjeX
            double[] arregloEjeX = FuncionesEstadistica.Matlab.Linspace(minimo,maximo,paso).ToArray();
            
            Console.WriteLine("\n\n***Elementos del arreglo EjeX***");
            for (int i = 0; i <= arregloEjeX.Length - 1; i++)
            {
                Console.WriteLine(arregloEjeX[i]);
            }
            Console.WriteLine("Número de elementos del arreglo EjeX: " + arregloEjeX.Length);

            //Creación del arreglo para la función de densidad
            //Con el mismo tamaño que el arreglo del Eje X
            double[] funcionDensidad = new double[arregloEjeX.Length];
            funcionDensidad = FuncionesEstadistica.Matlab.Normpdf(arregloEjeX, media, desviacionE);
            Console.WriteLine("\n\n***Elementos del arreglo funcionDensidad***");
              for(int i = 0; i <= funcionDensidad.Length - 1; i++)
              {
                  Console.WriteLine(funcionDensidad[i]);
              }

            //**** Calcular la probabilidad de la región [valorA,valorB] con RectanZ ****
            Console.WriteLine("Valor A");
            double valorA;
            valorA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Valor B");
            double valorB;
            valorB = Convert.ToDouble(Console.ReadLine());

                //Usando la librería
            double probabilidadRectanZ = FuncionesEstadistica.Matlab.RectanZ(arregloEjeX, funcionDensidad, valorA, valorB, paso);
            Console.WriteLine("\n\nEl promedio RectanZ es: " + probabilidadRectanZ);

                //**** Calcular la probabilidad de la región [valorA,valorB] con TrapZ ****
            double probabilidadTrapZ = FuncionesEstadistica.Matlab.Trapz(arregloEjeX, funcionDensidad, valorA, valorB, paso);
            Console.WriteLine("\n\nEl promedio TrapZ es: " + probabilidadTrapZ);

           Console.ReadLine();
        }
    }
}
