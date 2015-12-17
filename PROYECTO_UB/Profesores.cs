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
    public partial class Profesores : Form
    {
        public Profesores()
        {
            InitializeComponent();
        }

        private void btn_ag_comuna_Click(object sender, EventArgs e)
        {
            COMUNAS obj = new COMUNAS();
            obj.ShowDialog();
            CargarBanco();
        }

        private void btn_ag_banco_Click(object sender, EventArgs e)
        {
            Bancos obj = new Bancos();
            obj.ShowDialog();
            CargarBanco();
          
        }
        private void CargarBanco()
        { 
        
        
        
        
        }
        private void Profesores_Load(object sender, EventArgs e)
        {

        }

        private void txt_rut_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_rut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

               
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (txt_rut.Text == "" || txt_dv.Text == "" )
            {
                MessageBox.Show("Ingrese el rut", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_rut.Focus();
                return;
            }

            if (txt_nombre.Text == "")
            {
                MessageBox.Show("Ingrese el Nonbre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nombre.Focus();
                return;
            }
            if (this.txt_app.Text == "")
            {
                MessageBox.Show("Ingrese Apellido paterno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_app.Focus();
                return;
            }

            if (txt_apm.Text == "")
            {
                MessageBox.Show("Ingrese Apellido paterno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_apm.Focus();
                return;
            }
            if (this.txt_celular.Text == "")
            {
                MessageBox.Show("seleccione comuna", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_celular.Focus();
                return;
            }
            if (this.cBox_comuna.Text == "")
            {
                MessageBox.Show("seleccione comuna", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cBox_comuna.Focus();
                return;
            }
            if (this.cBox_banco.Text == "")
            {
                MessageBox.Show("seleccione comuna", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cBox_banco.Focus();
                return;
            }
            if (this.txt_Ncta.Text == "")
            {
                MessageBox.Show("seleccione comuna", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Ncta.Focus();
                return;
            }
            if (this.cBox_cuenta.Text == "")
            {
                MessageBox.Show("seleccione comuna", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cBox_cuenta.Focus();
                return;
            }
        }
    }
}
