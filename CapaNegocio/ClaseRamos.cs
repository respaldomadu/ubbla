using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{// ramos listos
    public class ClaseRamos
    {
        public ClaseConexion objconexion = new ClaseConexion();

        public string codigo { get; set; }
        public string nombre { get; set; }
        public int semana { get; set; }
        public int horas  { get; set; }
        public int valorH { get; set; }

        public DataTable Listado()
        {
            return objconexion.Listado("SP_LISTAR_RAMO", null);
        }

        public String RegistrarRamo()
        {
            List<ClaseParametros> lst = new List<ClaseParametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new ClaseParametros("@CODIGO", codigo));
                lst.Add(new ClaseParametros("@NOMBRE", nombre));                
                lst.Add(new ClaseParametros("@HORAS", horas));
                lst.Add(new ClaseParametros("@N_SEMANAS", semana));
                lst.Add(new ClaseParametros("@VALOR", valorH));

                lst.Add(new ClaseParametros("@MENSAJE", "", SqlDbType.VarChar, ParameterDirection.Output, 150));
                objconexion.EjecutarSP("SP_INGRESAR_RAMO", ref lst);
                Mensaje = lst[5].Valor.ToString();
            }
            catch (Exception)
            {
                throw;
            }
            return Mensaje;
        }

        public String ActualizarRamo()
        {
            List<ClaseParametros> lst = new List<ClaseParametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new ClaseParametros("@CODIGO", codigo));
                lst.Add(new ClaseParametros("@NOMBRE", nombre));
                lst.Add(new ClaseParametros("@HORAS", horas));
                lst.Add(new ClaseParametros("@N_SEMANAS", semana));
                lst.Add(new ClaseParametros("@VALOR", valorH));

                lst.Add(new ClaseParametros("@MENSAJE", "", SqlDbType.VarChar, ParameterDirection.Output, 150));
                objconexion.EjecutarSP("SP_actualizar_RAMO", ref lst);
                Mensaje = lst[5].Valor.ToString();
            }
            catch (Exception)
            {
                throw;
            }
            return Mensaje;
        }


        public String EliminarRamo()
        {
            List<ClaseParametros> lst = new List<ClaseParametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new ClaseParametros("@CODIGO", codigo));
                lst.Add(new ClaseParametros("@MENSAJE", "", SqlDbType.VarChar, ParameterDirection.Output, 150));
                objconexion.EjecutarSP("SP_ELIMINAR_RAMO", ref lst);
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
                lst.Add(new ClaseParametros("@NOMBRE", textoUsuario));
                dt = objconexion.Listado("SP_BUSCAR_RAMO", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }















    }









}
