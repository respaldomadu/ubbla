﻿using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
  public  class ClaseHorario
    {
        public ClaseConexion objconexion = new ClaseConexion();
        public int codigo_h { get; set; }
        public int codigo_pla { get; set; }
        public int codigo_mo { get; set; }
        public string fecha { get; set; }

        public string estado { get; set; }

        public DataTable Listado()
        {
            return objconexion.Listado("SP_LISTAR_HORARIO", null);
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
        public String RegistrarHorario()
        {
            List<ClaseParametros> lst = new List<ClaseParametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new ClaseParametros("@COD_H", codigo_h));
                lst.Add(new ClaseParametros("@COD_P", codigo_pla));
                lst.Add(new ClaseParametros("@COD_M", codigo_mo));
                lst.Add(new ClaseParametros("@FECHA", fecha));

                lst.Add(new ClaseParametros("@ESTADO", estado));

                lst.Add(new ClaseParametros("@MENSAJE", "", SqlDbType.VarChar, ParameterDirection.Output, 150));
                objconexion.EjecutarSP("SP_INGRESAR_HORARIO", ref lst);
                Mensaje = lst[5].Valor.ToString();
            }
            catch (Exception)
            {
                throw;
            }
            return Mensaje;
        }
        public String ActualizarHorario()
        {
            List<ClaseParametros> lst = new List<ClaseParametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new ClaseParametros("@COD_H", codigo_h));
                lst.Add(new ClaseParametros("@COD_P", codigo_pla));
                lst.Add(new ClaseParametros("@COD_M", codigo_mo));
                lst.Add(new ClaseParametros("@FECHA", fecha));
                lst.Add(new ClaseParametros("@ESTADO", estado));
           
                lst.Add(new ClaseParametros("@MENSAJE", "", SqlDbType.VarChar, ParameterDirection.Output, 150));
                objconexion.EjecutarSP("SP_ACTUALIZAR_HORARIO", ref lst);
                Mensaje = lst[5].Valor.ToString();
            }
            catch (Exception)
            {
                throw;
            }
            return Mensaje;
        }
        public String EliminarHorario()
        {
            List<ClaseParametros> lst = new List<ClaseParametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new ClaseParametros("@COD_H", codigo_h));
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
                 lst.Add(new ClaseParametros("@COD_P",codigo_pla ));
                lst.Add(new ClaseParametros("@COD_M", codigo_mo));
                lst.Add(new ClaseParametros("@FECHA", fecha));

                dt = objconexion.Listado("SP_BUSCAR_HORARIO", lst);
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
