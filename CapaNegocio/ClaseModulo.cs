using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class ClaseModulo
    {



        public ClaseConexion objconexion = new ClaseConexion();

        public int codigo { get; set; }
        public string inicio { get; set; }
        public string fin { get; set; }
        public string dia { get; set; }


        public DataTable Listado()
        {
            return objconexion.Listado("SP_LISTAR_MODULO", null);
        }
        public int MAYOR()
        {

            string MAX = "0";
            DataTable datos = new DataTable();
            datos = Listado();
            if (datos.Rows.Count != 0)
            {
                MAX = datos.AsEnumerable().Max(row => row[0]).ToString();

            } return int.Parse(MAX) + 1;
        }
        public String RegistrarModulo()
        {
            List<ClaseParametros> lst = new List<ClaseParametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new ClaseParametros("@COD_m", codigo));
                lst.Add(new ClaseParametros("@INICIO", inicio));
                lst.Add(new ClaseParametros("@FIN", fin));
                lst.Add(new ClaseParametros("@DIA", dia));
                lst.Add(new ClaseParametros("@MENSAJE", "", SqlDbType.VarChar, ParameterDirection.Output, 150));
                objconexion.EjecutarSP("SP_INGRESAR_MODULO", ref lst);
                Mensaje = lst[4].Valor.ToString();
            }
            catch (Exception)
            {
                throw;
            }
            return Mensaje;
        }



        public String ActualizarModulo()
        {
            List<ClaseParametros> lst = new List<ClaseParametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new ClaseParametros("@COD_m", codigo));
                lst.Add(new ClaseParametros("@INICIO", inicio));
                lst.Add(new ClaseParametros("@FIN", fin));
                lst.Add(new ClaseParametros("@DIA", dia));
                lst.Add(new ClaseParametros("@MENSAJE", "", SqlDbType.VarChar, ParameterDirection.Output, 150));
                objconexion.EjecutarSP("SP_ACTUALIZAR_MODULO", ref lst);
                Mensaje = lst[4].Valor.ToString();
            }
            catch (Exception)
            {
                throw;
            }
            return Mensaje;
        }



        public String EliminarModulo()
        {
            List<ClaseParametros> lst = new List<ClaseParametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new ClaseParametros("@COD_M", codigo));
                lst.Add(new ClaseParametros("@MENSAJE", "", SqlDbType.VarChar, ParameterDirection.Output, 150));
                objconexion.EjecutarSP("SP_ELIMINAR_MODULO", ref lst);
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
                lst.Add(new ClaseParametros("@DIA", textoUsuario));
                dt = objconexion.Listado("SP_BUSCAR_HORARIO", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }


    }

}
