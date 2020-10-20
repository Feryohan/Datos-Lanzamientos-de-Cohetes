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
            path = @"C:\Users\SERGIO ROMO\Documents\Semestre 2021-1\Temas Selectos de Programación\Lanzamientos Espaciales Exitosos\50datosdelanzamientosexitosos.xlsx";

            //Libreria SpreadsheetLight version 3.4.9 instalada desde el NuGet
            //DocumentFormat.OpenXml version 2.5.0 instalada desde el NuGet
            SLDocument sl = new SLDocument(path);

            //Los arreglos comienzan en cero
            //Las filas comienzan en uno

            //El indice, para la fila, empieza en el dos
            int iRow = 2;

            //Creación del arreglo 
            int[] arregloLanzamientos = new int[50];

            //El ciclo while se aplica hasta que no se encuentre un registro vacío
                                                                //fila/columna
            while (!string.IsNullOrEmpty(sl.GetCellValueAsString(iRow, 2)))
            {
                //Se añade al arreglo
                arregloLanzamientos[iRow - 2] = sl.GetCellValueAsInt32(iRow, 2);

                //Se muestra en pantalla
                Console.WriteLine(arregloLanzamientos[iRow - 2]);

                iRow++;
            }

            //Se muestra la suma de los 50 datos
            Console.WriteLine("\n\nSUMA = " + FuncionesEstadistica.Matlab1.Sum(arregloLanzamientos));

            //Se muestra el promedio de los 50 datos
            Console.WriteLine("\nPromedio = " + FuncionesEstadistica.Matlab1.Mean(arregloLanzamientos));

            //Se muestra el valor mínimo de los 50 datos
            Console.WriteLine("\nMínimo = " + FuncionesEstadistica.Matlab1.Min(arregloLanzamientos));

            //Se muestra el valor máximo de los 50 datos
            Console.WriteLine("\nMáximo = " + FuncionesEstadistica.Matlab1.Max(arregloLanzamientos));

            //Se muestra la varianza poblacional de los 50 datos
            Console.WriteLine("\nVarianza Poblacional = " + FuncionesEstadistica.Matlab2.VarP(arregloLanzamientos));

            //Se muestra la desviación estandar poblacional de los 50 datos
            Console.WriteLine("\nDesviacion Estandar Poblacional = " + FuncionesEstadistica.Matlab2.StdP(arregloLanzamientos));

            //Se muestra la varianza muestral de los 50 datos
            Console.WriteLine("\nVarianza Muestral = " + FuncionesEstadistica.Matlab2.VarM(arregloLanzamientos));

            //Se muestra la desviación estandar muestral de los 50 datos
            Console.WriteLine("\nDesviacion Estandar Poblacional = " + FuncionesEstadistica.Matlab2.StdM(arregloLanzamientos));

            Console.ReadLine();

        }
    }
}
