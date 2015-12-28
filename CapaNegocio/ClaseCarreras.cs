using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace CapaNegocio
{
   public class ClaseCarreras
    {
        public ClaseConexion objconexion = new ClaseConexion();

        public string codigo { get; set; }
        public string nombre { get; set; }
       

        public DataTable Listado()
        {
            return objconexion.Listado("SP_LISTAR_CARRERA", null);
        }

        public String RegistrarCarreras()
        {
            List<ClaseParametros> lst = new List<ClaseParametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new ClaseParametros("@COD_C", codigo));
                lst.Add(new ClaseParametros("@NOMBRE_C", nombre));
                lst.Add(new ClaseParametros("@MENSAJE", "", SqlDbType.VarChar, ParameterDirection.Output, 150));
                objconexion.EjecutarSP("SP_INGRESAR_CARRERA", ref lst);
                Mensaje = lst[2].Valor.ToString();
            }
            catch (Exception)
            {
                throw;
            }
            return Mensaje;
        }



        public String ActualizarCarreras()
        {
            List<ClaseParametros> lst = new List<ClaseParametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new ClaseParametros("@COD_C", codigo));
                lst.Add(new ClaseParametros("@NOMBRE_C", nombre));
                lst.Add(new ClaseParametros("@MENSAJE", "", SqlDbType.VarChar, ParameterDirection.Output, 150));
                objconexion.EjecutarSP("SP_ACTUALIZAR_CARRERA", ref lst);
                Mensaje = lst[2].Valor.ToString();
            }
            catch (Exception)
            {
                throw;
            }
            return Mensaje;
        }



        public String EliminarCarreras()
        {
            List<ClaseParametros> lst = new List<ClaseParametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new ClaseParametros("@COD_C", codigo));
                lst.Add(new ClaseParametros("@MENSAJE", "", SqlDbType.VarChar, ParameterDirection.Output, 150));
                objconexion.EjecutarSP("SP_ELIMINAR_CARRERA", ref lst);
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
                lst.Add(new ClaseParametros("@NOMBRE_C", textoUsuario));
                dt = objconexion.Listado("SP_BUSCAR_CARRERA", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
        public DataTable Cargar(String textoUsuario)
        {
            DataTable dt = new DataTable();
            List<ClaseParametros> lst = new List<ClaseParametros>();
            try
            {
                lst.Add(new ClaseParametros("@COD", textoUsuario));

                dt = objconexion.Listado("SP_CARGAR_CARRERAS", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }

    }
}
