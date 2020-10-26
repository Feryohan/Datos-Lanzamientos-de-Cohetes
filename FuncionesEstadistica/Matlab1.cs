using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Libreria FuncionesEstadistica
namespace FuncionesEstadistica
{
    //Clase Matlab1
    public class Matlab1
    {
        #region SUMA
        //Método que calcula la suma de todos los elementos de un arreglo
        public static int Sum(int[] arreglo)
        {
            //El arreglo tiene que tener 2 o más elementos para hacer la suma
            if (arreglo.Length > 2)
            {
                int sum = arreglo[0];

                for (int i = 1; i <= arreglo.Length - 1; i++)
                {
                    sum = sum + arreglo[i];
                }

                return sum;
            }
            else
            {
                return 0;
            }
        }
        #endregion

        #region PROMEDIO
        //Método que calcula el promedio de los elementos de un arreglo
        public static double Mean(int[] arreglo)
        {
            //El promedio solo se calcula si el arreglo tiene más de 2 elementos
            if (arreglo.Length > 2)
            {
                double mean = Convert.ToDouble(Sum(arreglo)) / arreglo.Length;

                return mean;
            }
            else
            {
                return 0;
            }
        }
        #endregion

        #region MINIMO
        //Método que calcula el mínimo valor 
        public static int Min (int[] arreglo)
        {
            if (arreglo.Length > 2)
            {
                int min = arreglo[0];

                for(int i = 0; i<arreglo.Length; i++)
                {
                    if(min > arreglo[i])
                    {
                        min = arreglo[i];
                    }
                }

                return min;

            }
            else
            {
                return 0;
            }
        }
        #endregion

        #region MAXIMO
        //Método que calcula el mínimo valor 
        public static int Max(int[] arreglo)
        {
            if (arreglo.Length > 2)
            {
                int max = arreglo[0];

                for (int i = 0; i < arreglo.Length ; i++)
                {
                    if (max < arreglo[i])
                    {
                        max = arreglo[i];
                    }
                }

                return max;

            }
            else
            {
                return 0;
            }
        }
        #endregion

    }
}
