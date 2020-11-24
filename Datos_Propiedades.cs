using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanzamientos_Espaciales_Exitosos
{
    class Datos_Propiedades
    {
        #region Variables
        public string rutaArchivo { get; set; }
        public string nombreDatos { get; set; }
        public int [] alturas { get; set; }
        public double promedio { get; set; }
        public double maxValFunDensi { get; set; }
        public double minValFunDensi { get; set; }
        public double desviacionEstandar { get; set; }

        #endregion

        #region Constructor
        //Constructor
        public Datos_Propiedades()
        {
            rutaArchivo = "";
        }
        #endregion
    }
}
