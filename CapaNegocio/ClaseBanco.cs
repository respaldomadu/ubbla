﻿using CapaDatos;
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
            return objconexion.Listado("SP_LISTAR_BANCOS", null);
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
        public String RegistrarBanco()
        {
            List<ClaseParametros> lst = new List<ClaseParametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new ClaseParametros("@CODIGO_B", codigo));
                lst.Add(new ClaseParametros("@NOMBRE_B", nombre));
                lst.Add(new ClaseParametros("@MENSAJE", "", SqlDbType.VarChar, ParameterDirection.Output, 150));
                objconexion.EjecutarSP("SP_INGRESAR_BANCOS", ref lst);
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
                lst.Add(new ClaseParametros("@NOMBRE_BCO", nombre));
                lst.Add(new ClaseParametros("@MENSAJE", "", SqlDbType.VarChar, ParameterDirection.Output, 150));
                objconexion.EjecutarSP("SP_ACTUALIZAR_BANCOS", ref lst);
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
                objconexion.EjecutarSP("SP_ELIMINAR_BANCOS", ref lst);
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
                lst.Add(new ClaseParametros("@NOMBRE_B", textoUsuario));
                dt = objconexion.Listado("SP_BUSCAR_BANCOS", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }

    }
}
