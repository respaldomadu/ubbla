using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace PROYECTO_UB
{
    public partial class Bancos : Form
    {
        private ClaseBanco objBanco = new ClaseBanco();
        public Bancos()
        {
            InitializeComponent();
        }

        private void Bancos_Load(object sender, EventArgs e)
        {

        }
        private void ListarBanco()
        {
            dataGridView1.DataSource = objBanco.Listado();
        }
        private void Limpiar()
        {
            txt_codigo.Text = "";
            txt_nombre.Text = "";
            txt_buscar.Text = "";
            btn_actualizar.Enabled = false;
            btn_eliminar.Enabled = false;
            btn_agregar.Enabled = true;
            txt_codigo.Enabled = true;

        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {

            if (txt_codigo.Text == "")
            {
                MessageBox.Show("Ingrese el Codigo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_codigo.Focus();
                return;
            }

            if (txt_nombre.Text == "")
            {
                MessageBox.Show("Ingrese el Nonbre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nombre.Focus();
                return;
            }

            objBanco.codigo = txt_codigo.Text;
            objBanco.nombre = txt_nombre.Text;
            MessageBox.Show(objBanco.RegistrarBanco(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ListarBanco();
            Limpiar();
        }
    }
}
