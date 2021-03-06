﻿using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
   public class ClaseTipoCuenta
    {
    public ClaseConexion objconexion = new ClaseConexion();


    public int codigo { get; set; }
    public string nombre { get; set; }

    public DataTable Listado()
    {
        return objconexion.Listado("SP_LISTAR_CUENTA", null);
    }
    public int MAYOR() {

        string MAX = "0";
        DataTable datos = new DataTable();
        datos = Listado();
        if(datos.Rows.Count!= 0){
            MAX = datos.AsEnumerable().Max(row => row[0]).ToString();

        } return int.Parse(MAX)+1;
    }
    public String RegistrarCTA()
    {
        List<ClaseParametros> lst = new List<ClaseParametros>();
        String Mensaje = "";
        try
        {
            lst.Add(new ClaseParametros("@CODIGO_CU", codigo));
            lst.Add(new ClaseParametros("@NOMBRE_CU", nombre));
            lst.Add(new ClaseParametros("@MENSAJE", "", SqlDbType.VarChar, ParameterDirection.Output, 150));
            objconexion.EjecutarSP("SP_INGRESAR_CUENTA", ref lst);
            Mensaje = lst[2].Valor.ToString();
        }
        catch (Exception)
        {
            throw;
        }
        return Mensaje;
    }
    public String ActualizarCTA()
    {
        List<ClaseParametros> lst = new List<ClaseParametros>();
        String Mensaje = "";
        try
        {
            lst.Add(new ClaseParametros("@COD_CU", codigo));
            lst.Add(new ClaseParametros("@NOMBRE_CU", nombre));
            lst.Add(new ClaseParametros("@MENSAJE", "", SqlDbType.VarChar, ParameterDirection.Output, 150));
            objconexion.EjecutarSP("SP_ACTUALIZAR_CUENTA", ref lst);
            Mensaje = lst[2].Valor.ToString();
        }
        catch (Exception)
        {
            throw;
        }
        return Mensaje;
    }

    public String EliminarCTA()
    {
        List<ClaseParametros> lst = new List<ClaseParametros>();
        String Mensaje = "";
        try
        {
            lst.Add(new ClaseParametros("@COD_CU", codigo));
            lst.Add(new ClaseParametros("@MENSAJE", "", SqlDbType.VarChar, ParameterDirection.Output, 150));
            objconexion.EjecutarSP("SP_ELIMINAR_CUENTA", ref lst);
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
            lst.Add(new ClaseParametros("@NOMBRE_CU", textoUsuario));
            dt = objconexion.Listado("SP_BUSCAR_CUENTA", lst);
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return dt;
    }











    }
}
