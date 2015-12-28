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
    public partial class BuscarCarrera : Form
    {
        ClaseCarreras objCa = new ClaseCarreras();
        public static string codigo = "";
        public BuscarCarrera()
        {
            InitializeComponent();
        }
        private void ListarCarreras()
        {
            dataGridView1.DataSource = objCa.Listado();
        }
        private void BuscarCarrera_Load(object sender, EventArgs e)
        {
            ListarCarreras();
            codigo = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            this.Close();
        }
    }
}
