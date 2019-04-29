using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Clases
{
    public class Usuario
    {
        #region PROPIEDADES

        public string Pro_CodigoEmpleado { get; set; }
        public string Pro_NombreEmpleado { get; set; }
        public string Pro_Usuario { get; set; }
        public int Pro_ID_NivelAcceso { get; set; }
        public string Pro_Descripcion_NivelAcceso { get; set; }
        public string Pro_CargoEmpleado { get; set; }
     

        #endregion
    }
}
