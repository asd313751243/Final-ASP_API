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
        public string Cedula_Empleado { get; set; }
        public string Fecha_Nac_Empleado { get; set; }
        public string Telefono_Empleado { get; set; }
        public string Id_Fk_Sucursal { get; set; }
    }
}
