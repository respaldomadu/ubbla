using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_UB
{
    public partial class BuscarPlanificaciones : Form
    {
        ClasePlanificacion objPlan = new ClasePlanificacion();
       
        public static string rut = "";
        public BuscarPlanificaciones()
        {
            InitializeComponent();
        }

        private void BuscarPlanificaciones_Load(object sender, EventArgs e)
        {
            ListarPlanificaciones();

        }
        private void ListarPlanificaciones()
        {
            dataGridView1.DataSource = objPlan.Listado();
        }
    }
}
