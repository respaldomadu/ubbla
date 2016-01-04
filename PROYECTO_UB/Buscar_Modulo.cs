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
    public partial class Buscar_Modulo : Form
    {
        ClaseModulo objmo = new ClaseModulo();
        public static string codigo = "";
        public Buscar_Modulo()
        {
            InitializeComponent();
        }

        private void Buscar_Modulo_Load(object sender, EventArgs e)
        {
            ListarModulo();
            codigo = "";
        
        }
        private void ListarModulo()
        {
            dataGridView1.DataSource = objmo.Listado();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            this.Close();
        }
    }
}
