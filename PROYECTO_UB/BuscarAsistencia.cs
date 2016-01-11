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
    public partial class BuscarAsistencia : Form
    {
        private ClasesAsistencia objAs = new ClasesAsistencia();
        public BuscarAsistencia()
        {
            InitializeComponent();
        }
        private void ListarAsistencia()
        {
            dataGridView1.DataSource = objAs.Listado();
        }
        private void BuscarAsistencia_Load(object sender, EventArgs e)
        {
            ListarAsistencia();
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objAs.Buscar(txt_buscar.Text, txt_busapp.Text, txt_busapm.Text,txt_asignatura.Text);
        }

        private void txt_busapp_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objAs.Buscar(txt_buscar.Text, txt_busapp.Text, txt_busapm.Text,txt_asignatura.Text);
        }

        private void txt_busapm_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objAs.Buscar(txt_buscar.Text, txt_busapp.Text, txt_busapm.Text,txt_asignatura.Text);
        }

        private void txt_asignatura_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objAs.Buscar(txt_buscar.Text, txt_busapp.Text, txt_busapm.Text, txt_asignatura.Text);
        }
    }
}
