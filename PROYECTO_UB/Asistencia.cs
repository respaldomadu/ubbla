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
    public partial class Asistencia : Form
    {
        ClasesAsistencia objas = new ClasesAsistencia();
        public Asistencia()
        {
            InitializeComponent();
        }

        private void txt_cod_barra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                objas.cod_plani = int.Parse(txt_cod_barra.Text);
                ListarAsistencia();
               MessageBox.Show(objas.RegistrarAsitencia(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }
        private void ListarAsistencia()
        {
            dataGridView1.DataSource = objas.Listado();
        }
        private void Asistencia_Load(object sender, EventArgs e)
        {
            
        }
    }
}
