using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
  public  class ClasePlanificacion
    {
        public ClaseConexion objconexion = new ClaseConexion();

        public int codigo { get; set; }
        public string rut { get; set; }
        public string codigoR { get; set; }
        public string codigoC { get; set; }
        public int anio { get; set; }
        public int periodo { get; set; }
        public int seccion { get; set; }
       
        
        public DataTable Listado()
        {
            return objconexion.Listado("SP_LISTAR_PLANIFICACION", null);
        }
       
        public String RegistrarPlanificacion()
        {
            List<ClaseParametros> lst = new List<ClaseParametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new ClaseParametros("@COD_PLANI", codigo));
                lst.Add(new ClaseParametros("@RUT_P", rut));
                lst.Add(new ClaseParametros("@COD_RAMO", codigoR));
                lst.Add(new ClaseParametros("@COD_CARRERA", rut));
                lst.Add(new ClaseParametros("@ANIO", anio));
                lst.Add(new ClaseParametros("@PERIODO", periodo));
                lst.Add(new ClaseParametros("@SECCION", seccion));
                lst.Add(new ClaseParametros("@MENSAJE", "", SqlDbType.VarChar, ParameterDirection.Output, 150));
                objconexion.EjecutarSP("SP_INGRESAR_PLANIFICACION", ref lst);
                Mensaje = lst[7].Valor.ToString();
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
                lst.Add(new ClaseParametros("@COD_PLANI", codigo));
                lst.Add(new ClaseParametros("@RUT_P", rut));
                lst.Add(new ClaseParametros("@COD_RAMO", codigoR));
                lst.Add(new ClaseParametros("@COD_CARRERA", codigoC));
                lst.Add(new ClaseParametros("@ANIO", anio));
                lst.Add(new ClaseParametros("@PERIODO", periodo));
                lst.Add(new ClaseParametros("@SECCION", seccion));
                lst.Add(new ClaseParametros("@MENSAJE", "", SqlDbType.VarChar, ParameterDirection.Output, 150));
                objconexion.EjecutarSP("SP_ACTUALIZAR_PLANIFICACION", ref lst);
                Mensaje = lst[7].Valor.ToString();
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
                lst.Add(new ClaseParametros("@COD_PLA", codigo));
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
                lst.Add(new ClaseParametros("@COD_RAMO", codigoR));
                lst.Add(new ClaseParametros("@COD_CARRERA", codigoC));
                lst.Add(new ClaseParametros("@RUT_P", rut));

                dt = objconexion.Listado("SP_BUSCAR_PLANIFICACION", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
       
    }
}
