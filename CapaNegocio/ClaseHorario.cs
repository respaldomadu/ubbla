using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    class ClaseHorario
    {
        public ClaseConexion objconexion = new ClaseConexion();

        public int codigo_pla { get; set; }
        public int codigo_mo { get; set; }
        public DateTime fecha { get; set; }
        public string hora_ing { get; set; }
        public string hora_sali { get; set; }
        public string hora_sali { get; set; }
        public string estado { get; set; }
        
        public DataTable Listado()
        {
            return objconexion.Listado("SP_LISTAR_PROFESORES", null);
        }
        public String RegistrarProfesores()
        {
            List<ClaseParametros> lst = new List<ClaseParametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new ClaseParametros("@RUT", rut));
                lst.Add(new ClaseParametros("@DV", dv));
                lst.Add(new ClaseParametros("@NOMBRE_PROFESOR", nombre));
                lst.Add(new ClaseParametros("@AP_PAT", apellido_p));
                lst.Add(new ClaseParametros("@AP_MAT", apellido_m));
                lst.Add(new ClaseParametros("@FECHA_NAC", fecha_ncto));
                lst.Add(new ClaseParametros("@SEXO", sexo));
                lst.Add(new ClaseParametros("@MENSAJE", "", SqlDbType.VarChar, ParameterDirection.Output, 150));
                objconexion.EjecutarSP("SP_INGRESAR_PROFESOR", ref lst);
                Mensaje = lst[15].Valor.ToString();
            }
            catch (Exception)
            {
                throw;
            }
            return Mensaje;
        }
        public String ActualizarProfesores()
        {
            List<ClaseParametros> lst = new List<ClaseParametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new ClaseParametros("@RUT", rut));
                lst.Add(new ClaseParametros("@DV", dv));
                lst.Add(new ClaseParametros("@COD_NACI", cod_nacio));
                lst.Add(new ClaseParametros("@MENSAJE", "", SqlDbType.VarChar, ParameterDirection.Output, 150));
                objconexion.EjecutarSP("SP_ACTUALIZAR_PROFESOR", ref lst);
                Mensaje = lst[15].Valor.ToString();
            }
            catch (Exception)
            {
                throw;
            }
            return Mensaje;
        }
        public String EliminarProfesores()
        {
            List<ClaseParametros> lst = new List<ClaseParametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new ClaseParametros("@RUT", rut));
                lst.Add(new ClaseParametros("@MENSAJE", "", SqlDbType.VarChar, ParameterDirection.Output, 150));
                objconexion.EjecutarSP("SP_ELIMINAR_PROFESOR", ref lst);
                Mensaje = lst[1].Valor.ToString();
            }
            catch (Exception)
            {
                throw;
            }
            return Mensaje;
        }
        public DataTable Buscar(String nombre, String apellidoP, String materno)
        {
            DataTable dt = new DataTable();
            List<ClaseParametros> lst = new List<ClaseParametros>();
            try
            {
                lst.Add(new ClaseParametros("@NOMBRE", nombre));
                lst.Add(new ClaseParametros("@APELLIDO_P", apellidoP));
                lst.Add(new ClaseParametros("@APELLIDO_M", materno));

                dt = objconexion.Listado("SP_BUSCAR_PROFESOR", lst);
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
                lst.Add(new ClaseParametros("@RUT", textoUsuario));

                dt = objconexion.Listado("SP_CARGAR_PROFESORES", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }

    }
}
