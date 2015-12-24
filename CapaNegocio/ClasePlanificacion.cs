using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    class ClasePlanificacion
    {
        public ClaseConexion objconexion = new ClaseConexion();

        public int codigo { get; set; }
        public string nombre { get; set; }

        public DataTable Listado()
        {
            return objconexion.Listado("SP_LISTAR_COMUNA", null);
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
        public String Registrarplanificacion()
        {
            List<ClaseParametros> lst = new List<ClaseParametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new ClaseParametros("@CODIGO_CO", codigo));
                lst.Add(new ClaseParametros("@NOMBRE_CO", nombre));
                lst.Add(new ClaseParametros("@MENSAJE", "", SqlDbType.VarChar, ParameterDirection.Output, 150));
                objconexion.EjecutarSP("SP_INGRESAR_COMUNAS", ref lst);
                Mensaje = lst[2].Valor.ToString();
            }
            catch (Exception)
            {
                throw;
            }
            return Mensaje;
        }
    }
}
