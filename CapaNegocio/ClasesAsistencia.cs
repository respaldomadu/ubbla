using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
   public class ClasesAsistencia
   {
       public ClaseConexion objconexion = new ClaseConexion();

       public int codigo_as { get; set; }
       public string hora_in { get; set; }
       public string hora_s { get; set; }
       public int cod_plani { get; set; }
       public string fecha { get; set; }
       public string estado { get; set; }

       public DataTable Listado()
       {
           return objconexion.Listado("SP_LISTAR_ASISTENCIA", null);
       }
       public String RegistrarAsitencia()
       {
           List<ClaseParametros> lst = new List<ClaseParametros>();
           String Mensaje = "";
           try
           {
               lst.Add(new ClaseParametros("@COD_PLA", cod_plani));
               
               lst.Add(new ClaseParametros("@MENSAJE", "", SqlDbType.VarChar, ParameterDirection.Output, 150));
               objconexion.EjecutarSP("SP_INGRESAR_ASISTENCIA", ref lst);
               Mensaje = lst[1].Valor.ToString();
           }
           catch (Exception)
           {
               throw;
           }
           return Mensaje;
       }
       public DataTable Buscar(String nombre, String apellidoP, String materno, String asignatura)
       {
           DataTable dt = new DataTable();
           List<ClaseParametros> lst = new List<ClaseParametros>();
           try
           {
               lst.Add(new ClaseParametros("@NOMBRE", nombre));
               lst.Add(new ClaseParametros("@APELLIDO_P", apellidoP));
               lst.Add(new ClaseParametros("@APELLIDO_M", materno));
               lst.Add(new ClaseParametros("@ASIGNATURA", asignatura));


               dt = objconexion.Listado("SP_BUSCAR_ASISTENCIA", lst);
           }
           catch (Exception ex)
           {
               throw ex;
           }
           return dt;
       }

    }
}
