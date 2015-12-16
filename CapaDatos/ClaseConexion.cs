using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
  public  class ClaseConexion
    {
        public SqlConnection conexion = new SqlConnection("Data Source=192.168.11.134;Initial Catalog=UBdocentes;User ID=sa;Password=UBlosangeles2015");// strinfg de Conexion 

        //"Data Source=.;Initial Catalog=practico;Integrated Security = True"

        public void Conectar() // abrir conexion
        {
            if (conexion.State == ConnectionState.Closed)// consultar estado de conexion
                conexion.Open();
        }

        public void Desconectar()// cerrar conexion
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
        }


        public void EjecutarSP(String NombreSP, ref List<ClaseParametros> lst)
        {
            SqlCommand cmd;
            try
            {
                Conectar();
                cmd = new SqlCommand(NombreSP, conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                //Verificar si la lista Genérica no está vacia
                if (lst != null)
                {
                    //Recorremos la lista
                    for (int i = 0; i < lst.Count; i++)
                    {
                        //Verificamos si los parametros son de entrada
                        if (lst[i].Direccion == ParameterDirection.Input)
                            cmd.Parameters.AddWithValue(lst[i].Nombre, lst[i].Valor);
                        //Verificamos si los parametros son de salida
                        if (lst[i].Direccion == ParameterDirection.Output)
                            cmd.Parameters.Add(lst[i].Nombre, lst[i].TipoDato, lst[i].Tamaño).Direction = ParameterDirection.Output;
                    }
                    cmd.ExecuteNonQuery();
                    //Recuperamos los datos de Salida
                    for (int i = 0; i < lst.Count; i++)
                    {
                        if (cmd.Parameters[i].Direction == ParameterDirection.Output)
                            lst[i].Valor = cmd.Parameters[i].Value;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable Listado(String NombreSP, List<ClaseParametros> lst)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da;
            try
            {
                Conectar();
                da = new SqlDataAdapter(NombreSP, conexion);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                //Vrificamos if la lista no esta Vacia
                if (lst != null)
                {
                    //Recorremos la lista Genérica
                    for (int i = 0; i < lst.Count; i++)
                    {
                        //Pasamos cada uno de los parámetros
                        da.SelectCommand.Parameters.AddWithValue(lst[i].Nombre, lst[i].Valor);
                    }
                }
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            Desconectar();
            return dt;
        }

    }
}
