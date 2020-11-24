using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanzamientos_Espaciales_Exitosos
{
    public class ExcelViewModel
    {
        public string SerVivo { get; set; }
        public int Altura_centimetros { get; set; }

        public ExcelViewModel()
        {
            SerVivo = "";
            Altura_centimetros = 0;
        }

    }
}
