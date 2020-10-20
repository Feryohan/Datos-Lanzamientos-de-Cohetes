using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Libreria de FuncionesEstadistica
namespace FuncionesEstadistica
{
    //Clase Matlab2
    public class Matlab2
    {
        #region Varianza Poblacion
        //Método que calcula la varianza en función de toda la población
        public static double VarP(int [] arreglo)
        {
            if (arreglo.Length > 2)
            {
                double varp;
                double promedio = Matlab1.Mean(arreglo);
                double suma = 0;
                double desviacion;
                for(int i = 0; i<= arreglo.Length-1; i++)
                {
                    desviacion = Math.Pow(arreglo[i] - promedio, 2);
                    suma = suma + desviacion;
                }

                varp = suma / arreglo.Length;

                return varp;
            }
            else
            {
                return 0;
            }
        }
        #endregion

        #region Desviación Estandar Población
        //Metodo que calcula la desviación estandar de una población
        public static double StdP(int [] arreglo)
        {
            if (arreglo.Length > 2)
            {
                double stdp = Math.Sqrt(VarP(arreglo));
                return stdp;
            }
            else
            {
                return 0;
            }
        }
        #endregion

        #region Varianza Muestra
        //Método que calcula la varianza en función de una muestra
        public static double VarM(int[] arreglo)
        {
            if (arreglo.Length > 2)
            {
                double varm;
                double promedio = Matlab1.Mean(arreglo);
                double suma = 0;
                double desviacion;
                for (int i = 0; i <= arreglo.Length - 1; i++)
                {
                    desviacion = Math.Pow(arreglo[i] - promedio, 2);
                    suma = suma + desviacion;
                }

                varm = suma / (arreglo.Length-1);

                return varm;
            }
            else
            {
                return 0;
            }
        }
        #endregion

        #region Desviación Estandar Muestra
        //Metodo que calcula la desviación estandar de una población
        public static double StdM(int[] arreglo)
        {
            if (arreglo.Length > 2)
            {
                double stdm = Math.Sqrt(VarM(arreglo));
                return stdm;
            }
            else
            {
                return 0;
            }
        }
        #endregion

    }
}
