using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class ClaseBanco
    {

        public ClaseConexion objconexion = new ClaseConexion();

        public string codigo { get; set; }
        public string nombre { get; set; }


        public DataTable Listado()
        {
            return objconexion.Listado("SP_LISTAR_BANCO", null);
        }

        public String RegistrarBanco()
        {
            List<ClaseParametros> lst = new List<ClaseParametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new ClaseParametros("@CODIGO_B", codigo));
                lst.Add(new ClaseParametros("@NOMBRE_B", nombre));
                lst.Add(new ClaseParametros("@MENSAJE", "", SqlDbType.VarChar, ParameterDirection.Output, 150));
                objconexion.EjecutarSP("SP_INGRESAR_BANCO", ref lst);
                Mensaje = lst[2].Valor.ToString();
            }
            catch (Exception)
            {
                throw;
            }
            return Mensaje;
        }



        public String ActualizarBanco()
        {
            List<ClaseParametros> lst = new List<ClaseParametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new ClaseParametros("@COD_BCO", codigo));
                lst.Add(new ClaseParametros("@NOMBRE_B", nombre));
                lst.Add(new ClaseParametros("@MENSAJE", "", SqlDbType.VarChar, ParameterDirection.Output, 150));
                objconexion.EjecutarSP("SP_ACTUALIZAR_BANCO", ref lst);
                Mensaje = lst[2].Valor.ToString();
            }
            catch (Exception)
            {
                throw;
            }
            return Mensaje;
        }



        public String EliminarBanco()
        {
            List<ClaseParametros> lst = new List<ClaseParametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new ClaseParametros("@COD_BCO", codigo));
                lst.Add(new ClaseParametros("@MENSAJE", "", SqlDbType.VarChar, ParameterDirection.Output, 150));
                objconexion.EjecutarSP("SP_ELIMINAR_BANCO", ref lst);
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
                lst.Add(new ClaseParametros("@NOMBRE_B", nombre));
                dt = objconexion.Listado("SP_BUSCAR_BANCO", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }

    }
}
