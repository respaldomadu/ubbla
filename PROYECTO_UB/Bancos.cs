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
            ListarBanco();
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

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            if (txt_nombre.Text == "")
            {
                MessageBox.Show("Ingrese el Nonbre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nombre.Focus();
                return;
            }

            objBanco.codigo = txt_codigo.Text;
            objBanco.nombre = txt_nombre.Text;
            objBanco.ActualizarBanco();
            MessageBox.Show(objBanco.ActualizarBanco(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ListarBanco();
            Limpiar();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

            objBanco.codigo = txt_codigo.Text;
            objBanco.EliminarBanco();
            MessageBox.Show(objBanco.EliminarBanco(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ListarBanco();
            Limpiar();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codigo.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txt_nombre.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txt_codigo.Enabled = false;
            btn_actualizar.Enabled = true;
            btn_eliminar.Enabled = true;
            btn_agregar.Enabled = false;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objBanco.Buscar(txt_buscar.Text);
        }

        private void btn_excel_Click(object sender, EventArgs e)
        {
            global.GridAExcel(dataGridView1);
        }

        private void txt_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
