using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
   public class ClaseComunas
    {
       public ClaseConexion objconexion = new ClaseConexion();

       public int codigo { get; set; }
       public string nombre { get; set; }

       public DataTable Listado()
       {
           return objconexion.Listado("SP_LISTAR_COMUNA", null);
       }

       public String RegistrarComunas()
       {
           List<ClaseParametros> lst = new List<ClaseParametros>();
           String Mensaje = "";
           try
           {
               lst.Add(new ClaseParametros("@CODIGO_CO", codigo));
               lst.Add(new ClaseParametros("@NOMBRE_CO", nombre));
               lst.Add(new ClaseParametros("@MENSAJE", "", SqlDbType.VarChar, ParameterDirection.Output, 150));
               objconexion.EjecutarSP("SP_INGRESAR_COMUNAS", ref lst);
               Mensaje = lst[2].Valor.ToString();
           }
           catch (Exception)
           {
               throw;
           }
           return Mensaje;
       }
       public String ActualizarComunas()
       {
           List<ClaseParametros> lst = new List<ClaseParametros>();
           String Mensaje = "";
           try
           {
               lst.Add(new ClaseParametros("@COD_COM", codigo));
               lst.Add(new ClaseParametros("@NOMBRE_COM", nombre));
               lst.Add(new ClaseParametros("@MENSAJE", "", SqlDbType.VarChar, ParameterDirection.Output, 150));
               objconexion.EjecutarSP("SP_ACTUALIZAR_COMUNAS", ref lst);
               Mensaje = lst[2].Valor.ToString();
           }
           catch (Exception)
           {
               throw;
           }
           return Mensaje;
       }
       public String EliminarComunas()
       {
           List<ClaseParametros> lst = new List<ClaseParametros>();
           String Mensaje = "";
           try
           {
               lst.Add(new ClaseParametros("@CODIGO_CO", codigo));
               lst.Add(new ClaseParametros("@MENSAJE", "", SqlDbType.VarChar, ParameterDirection.Output, 150));
               objconexion.EjecutarSP("SP_ELIMINAR_COMUNAS", ref lst);
               Mensaje = lst[1].Valor.ToString();
           }
           catch (Exception)
           {
               throw;
           }
           return Mensaje;
       }

       public DataTable Buscar(String textoUsuario)
       {
           DataTable dt = new DataTable();
           List<ClaseParametros> lst = new List<ClaseParametros>();
           try
           {
               lst.Add(new ClaseParametros("@NOMBRE_CO", textoUsuario));
               dt = objconexion.Listado("SP_BUSCAR_COMUNAS", lst);
           }
           catch (Exception ex)
           {
               throw ex;
           }
           return dt;
       }

    }
}
