using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class ClsEmpleado
    {
        public int opc { get; set; }
        public int Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FNacimiento {get; set; }
        public int Cargo { get; set; }
    }
}
