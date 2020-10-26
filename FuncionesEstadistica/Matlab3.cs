using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Libreria de FuncionesEstadistica
namespace FuncionesEstadistica
{
    //Clase Matlab3
    public class Matlab3
    {
        #region Linspace
        //Método que obtiene el arreglo del eje X de la función de densidad
        public static double[] Linspace(double min, double max, int paso)
        {
            double[] linspace = new double[paso];

            //El eje X comienza en el minimo valor de los datos
            //El eje X termina en el máximo valor de los datos
            linspace[0] = min;
            double incremento = (max - min) / (paso - 1);

            for (int i = 1; i <= linspace.Length - 1; i++)
            {
                //Formula para obtener la cantidad de puntos deseada ("paso")
                linspace[i] = Math.Round(linspace[i - 1] + incremento, 4);
            }

            return linspace;
        }
        #endregion

        #region Normpdf
        //Método que obtiene el arreglo de la función de densidad, a partir de los valores de Linspace obtenidos
        public static double[] Normpdf(double[] arregloSmash, double media, double desviacionE)
        {
            //Ambos arreglos tienen la misma longitud
            double[] normpdf = new double[arregloSmash.Length];
            double exponente;
            double varianza = Math.Pow(desviacionE, 2);
            for (int i = 0;i <= arregloSmash.Length-1; i++)
            {
                //Formula de función de densidad
                exponente = (-1) * (Math.Pow((arregloSmash[i] - media), 2) / (2 * varianza));
                normpdf[i] = Math.Round( (Math.Pow(Math.E, exponente)) / (desviacionE * Math.Sqrt(2 * Math.PI)) , 4);
            }

            return normpdf;

        }
        
        #endregion

    }
}
