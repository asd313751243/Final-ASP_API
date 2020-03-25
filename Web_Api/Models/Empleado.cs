using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Api.Models
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre_Empleado { get; set; }
        public string Sexo_Empleado { get; set; }
        public int Cedula_Empleado { get; set; }
        public DateTime Fecha_Nac_Empleado { get; set; }
        public int Telefono_Empleado { get; set; }
        public string Usuario_Empleado { get; set; }
        public string Contra_Empleado { get; set; }
        public int Id_Fk_Sucursal { get; set; }
    }
}
