using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
   public class ClaseConfiguracion
    {
        public ClaseConexion objconexion = new ClaseConexion();
       
        public String ActualizarConfiguracion(int anio, int periodo)
        {
            List<ClaseParametros> lst = new List<ClaseParametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new ClaseParametros("@ANIO", anio));
                lst.Add(new ClaseParametros("@PERIODO", periodo));
                lst.Add(new ClaseParametros("@MENSAJE", "", SqlDbType.VarChar, ParameterDirection.Output, 150));
                objconexion.EjecutarSP("SP_ACTUALIZAR_CONFIGURACIONES", ref lst);
                Mensaje = lst[2].Valor.ToString();
            }
            catch (Exception)
            {
                throw;
            }
            return Mensaje;
        }

        public DataTable Listado()
        {
            return objconexion.Listado("SP_LISTAR_CONFIGURACIONES", null);
        }

    }
}
