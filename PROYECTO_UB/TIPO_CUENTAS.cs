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
    public partial class TIPO_CUENTAS : Form
    {
        private ClaseTipoCuenta objCuenta = new ClaseTipoCuenta();
        public TIPO_CUENTAS()
        {
            InitializeComponent();
        }
        private void ListarCuentas()
        {
            dataGridView1.DataSource = objCuenta.Listado();
        }
         private void TIPO_CUENTAS_Load(object sender, EventArgs e)
        {
            ListarCuentas();
           txt_codigo.Text= objCuenta.MAYOR().ToString();
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
                return;
            }

            if (txt_nombre.Text == "")
            {
                MessageBox.Show("Ingrese el Nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nombre.Focus();
                return;
            }

            objCuenta.codigo = int.Parse(txt_codigo.Text);
            objCuenta.nombre = txt_nombre.Text;
            MessageBox.Show(objCuenta.RegistrarCTA(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ListarCuentas();
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

            objCuenta.codigo = int.Parse(txt_codigo.Text);
            objCuenta.nombre = txt_nombre.Text;
            objCuenta.ActualizarCTA();
            MessageBox.Show(objCuenta.ActualizarCTA(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            Limpiar();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            objCuenta.codigo = int.Parse(txt_codigo.Text);
            objCuenta.EliminarCTA();
            MessageBox.Show(objCuenta.EliminarCTA(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ListarCuentas();
            Limpiar();
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objCuenta.Buscar(txt_buscar.Text);
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

       
    }
}
