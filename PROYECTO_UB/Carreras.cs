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
    public partial class Carreras : Form
    {
        private ClaseCarreras objCarreras = new ClaseCarreras();
        public Carreras()
        {
            InitializeComponent();
        }
        private void ListarCarrera()
        {
            dataGridView1.DataSource = objCarreras.Listado();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ListarCarrera();
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

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (txt_codigo.Text == "")
            {
                MessageBox.Show("Ingrese el Codigo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_codigo.Focus();
                return; }

            if (txt_nombre.Text == "")
            {
                MessageBox.Show("Ingrese el Nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nombre.Focus();
                return;
             }

            objCarreras.codigo = txt_codigo.Text;
            objCarreras.nombre = txt_nombre.Text;
            MessageBox.Show(objCarreras.RegistrarCarreras(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ListarCarrera();
            Limpiar();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            if (txt_nombre.Text == "")
            {
                MessageBox.Show("Ingrese el Nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nombre.Focus();
                return;
            }
            
            objCarreras.codigo = txt_codigo.Text;
            objCarreras.nombre = txt_nombre.Text;
            objCarreras.ActualizarCarreras();
            MessageBox.Show(objCarreras.ActualizarCarreras(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ListarCarrera();
            Limpiar();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            objCarreras.codigo = txt_codigo.Text;
            objCarreras.EliminarCarreras();
            MessageBox.Show(objCarreras.EliminarCarreras(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ListarCarrera();
            Limpiar();
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objCarreras.Buscar(txt_buscar.Text);
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

        private void btn_excel_Click(object sender, EventArgs e)
        {
            global.GridAExcel(dataGridView1);
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }





    }
}
