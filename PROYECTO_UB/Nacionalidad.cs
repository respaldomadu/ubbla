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
    public partial class Nacionalidad : Form
    {
        private ClaseNacionalidad objNacio = new ClaseNacionalidad();
        public Nacionalidad()
        {
            InitializeComponent();
        }
        private void ListarNacionalidades()
        {
            dataGridView1.DataSource = objNacio.Listado();
        }
        private void Nacionalidad_Load(object sender, EventArgs e)
        {
            ListarNacionalidades();
            txt_codigo.Text = objNacio.MAYOR().ToString();

        }
        private void Limpiar()
        {
            txt_codigo.Text = "";
            txt_nombre.Text = "";
            txt_buscar.Text = "";
            btn_actualizar.Enabled = false;
            btn_eliminar.Enabled = false;
            btn_agregar.Enabled = true;
            txt_codigo.Text = objNacio.MAYOR().ToString();
            

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
          
            if (txt_nombre.Text == "")
            {
                MessageBox.Show("Ingrese el Nacionalidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nombre.Focus();
                return;
            }

            objNacio.codigo = int.Parse(txt_codigo.Text);
            objNacio.nacionalidad = txt_nombre.Text;
            MessageBox.Show(objNacio.RegistrarNacionalidad(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ListarNacionalidades();
            Limpiar();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            if (txt_nombre.Text == "")
            {
                MessageBox.Show("Ingrese Nacionalidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nombre.Focus();
                return;
            }

            objNacio.codigo =int.Parse( txt_codigo.Text);
            objNacio.nacionalidad = txt_nombre.Text;
            objNacio.ActualizarNacionalidad();
            MessageBox.Show(objNacio.ActualizarNacionalidad(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ListarNacionalidades();
            Limpiar();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            objNacio.codigo = int.Parse(txt_codigo.Text);
            objNacio.EliminarNacionalidad();
            MessageBox.Show(objNacio.EliminarNacionalidad(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ListarNacionalidades();
            Limpiar();
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objNacio.Buscar(txt_buscar.Text);
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
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

    }
}
