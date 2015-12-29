using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace PROYECTO_UB
{
   public static class Configuracion
    {
       
        public static int anio { get; set; }
        public static int periodo { get; set; }


        public static void datos()
        {ClaseConfiguracion objconfi = new ClaseConfiguracion();
            DataTable dt = new DataTable();
            dt = objconfi.Listado();

            anio = int.Parse(dt.Rows[0].ItemArray[0].ToString());
            periodo = int.Parse(dt.Rows[0].ItemArray[1].ToString());
        }
    }
}
