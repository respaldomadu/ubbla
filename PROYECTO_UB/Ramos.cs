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
    public partial class Ramos : Form
    {
        private ClaseRamos objRamo = new ClaseRamos();
        public Ramos()
        {
            InitializeComponent();
        }
        private void ListarRamo()
        {
            dataGridView1.DataSource = objRamo.Listado();
        }
        private void Limpiar()
        {
            txt_codigo.Text = "";
            txt_nombre.Text = "";
            txt_buscar.Text = "";
            txt_horas.Text = "";
            txt_semanas.Text = "";
            txt_valor.Text = "";
            btn_actualizar.Enabled = false;
            btn_eliminar.Enabled = false;
            btn_agregar.Enabled = true;
            txt_codigo.Enabled = true;

        }
        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Ramos_Load(object sender, EventArgs e)
        {
            ListarRamo();
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
            if (txt_horas.Text == "")
            {
                MessageBox.Show("Ingrese cantidad de horas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_horas.Focus();
                return;
            }

            if (txt_semanas.Text == "")
            {
                MessageBox.Show("Ingrese cantidad de semanas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_semanas.Focus();
                return;
            }
            if (txt_valor.Text == "")
            {
                MessageBox.Show("Ingrese valor por hora", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_valor.Focus();
                return;
            }
            objRamo.codigo = txt_codigo.Text;
            objRamo.nombre = txt_nombre.Text;
            objRamo.horas = int.Parse(txt_horas.Text);
            objRamo.valorH = int.Parse(txt_valor.Text);
            objRamo.semana = int.Parse(txt_semanas.Text);
            MessageBox.Show(objRamo.RegistrarRamo(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ListarRamo();
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
            
            if (txt_horas.Text == "")
            {
                MessageBox.Show("Ingrese cantidad de horas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_horas.Focus();
                return;
            }

            if (txt_semanas.Text == "")
            {
                MessageBox.Show("Ingrese cantidad de semanas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_semanas.Focus();
                return;
            }
            if (txt_valor.Text == "")
            {
                MessageBox.Show("Ingrese valor por hora", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_valor.Focus();
                return;
            }
            objRamo.codigo = txt_codigo.Text;
            objRamo.nombre = txt_nombre.Text;
            objRamo.horas = int.Parse(txt_horas.Text);
            objRamo.valorH = int.Parse(txt_valor.Text);
            objRamo.semana = int.Parse(txt_semanas.Text);
            MessageBox.Show(objRamo.ActualizarRamo(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            ListarRamo();
            Limpiar();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            objRamo.codigo = txt_codigo.Text;
            objRamo.EliminarRamo();
            MessageBox.Show(objRamo.EliminarRamo(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            ListarRamo();
            Limpiar();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_horas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_semanas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codigo.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txt_nombre.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

            txt_horas.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txt_valor.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txt_semanas.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();






            txt_codigo.Enabled = false;
            btn_actualizar.Enabled = true;
            btn_eliminar.Enabled = true;
            btn_agregar.Enabled = false;
        }

        private void btn_excel_Click(object sender, EventArgs e)
        {
            global.GridAExcel(dataGridView1);
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objRamo.Buscar(txt_buscar.Text);
        }

        private void txt_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}

