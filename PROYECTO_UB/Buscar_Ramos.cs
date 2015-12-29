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
    public partial class Buscar_Ramos : Form
    {
        ClaseRamos objRa = new ClaseRamos();
        public static string codigo = "";
       
        public Buscar_Ramos()
        {
            InitializeComponent();
        }
        private void ListarRamos()
        {
            dataGridView1.DataSource = objRa.Listado();
        }
        private void Buscar_Ramos_Load(object sender, EventArgs e)
        {
            ListarRamos();
            codigo = "";

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
           
            this.Close();
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objRa.Buscar(txt_buscar.Text);
        }
    }
}
