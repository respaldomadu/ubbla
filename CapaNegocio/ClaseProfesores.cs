using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
  public  class ClaseProfesores
    {
        public ClaseConexion objconexion = new ClaseConexion();

        public string rut { get; set; }
        public string dv { get; set; }
        public string nombre { get; set; }
        public string apellido_p { get; set; }
        public string apellido_m { get; set; }
        public DateTime fecha_ncto { get; set; }
        public string sexo { get; set; }
        public int celular { get; set; }
        public string num_cta { get; set; }
        public string tipo_cta { get; set; }
        public int cod_banco { get; set; }
        public int cod_comuna { get; set; }
    }
}
