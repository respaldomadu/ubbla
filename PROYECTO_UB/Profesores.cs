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
    public partial class Profesores : Form
    {
        private ClaseProfesores objProfesor = new ClaseProfesores();
        private ClaseComunas objComuna = new ClaseComunas();
        private ClaseTipoCuenta objTipoCta = new ClaseTipoCuenta();
        private ClaseBanco objBanco = new ClaseBanco();
        private ClaseNacionalidad objNacio = new ClaseNacionalidad();
        String Femenino = "";
        String Masculino = "";
        public Profesores()
        {
            InitializeComponent();
        }
        private void ListarProfesores()
        {
            dataGridView1.DataSource = objProfesor.Listado();
        }
        private void Profesores_Load(object sender, EventArgs e)
        {
            ListarProfesores();
            llenarCombobox();
        }
        private void Limpiar()
        {
            txt_rut.Text = "";
            txt_nombre.Text = "";
            txt_buscar.Text = "";
            txt_dv.Text = "";
            txt_busapm.Text = "";
            txt_busapp.Text = "";
            txt_celular.Text = "";
            txt_Ncta.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            txt_email.Text = "";
            
            btn_actualizar.Enabled = false;
            btn_eliminar.Enabled = false;
            btn_agregar.Enabled = true;
            

        }
        private void btn_ag_comuna_Click(object sender, EventArgs e)
        {
            Comunas obj = new Comunas();
            obj.ShowDialog();
            llenarCombobox();
        }

        private void btn_ag_banco_Click(object sender, EventArgs e)
        {
            Bancos obj = new Bancos();
            obj.ShowDialog();
            CargarBanco();
            llenarCombobox();
          
        }
        private void CargarBanco()
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
        private void llenarCombobox()
        {
            cBox_comuna.DataSource = objComuna.Listado();
            cBox_comuna.ValueMember = "CODIGO";
            cBox_comuna.DisplayMember = "COMUNA";
            //*********************************
            cBox_cuenta.DataSource = objTipoCta.Listado();
            cBox_cuenta.ValueMember = "CODIGO";
            cBox_cuenta.DisplayMember = "TIPO CUENTA";
            //*********************************
            cBox_banco.DataSource = objBanco.Listado();
            cBox_banco.ValueMember = "CODIGO";
            cBox_banco.DisplayMember="BANCO";
            //**********************************
            cBoxNacionalidad.DataSource = objNacio.Listado();
            cBoxNacionalidad.ValueMember = "CODIGO";
            cBoxNacionalidad.DisplayMember = "NACIONALIDAD";
            //************************************
           
            cBox_est_civil.Items.Add("Soltero");
            cBox_est_civil.Items.Add("Casado");
            cBox_est_civil.Items.Add("Viudo");
            cBox_est_civil.Items.Add("Divorciado");
        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (txt_rut.Text == "" || txt_dv.Text == "")
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
                MessageBox.Show("Ingrese celular", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_celular.Focus();
                return;
            }
            if (this.cBox_comuna.Text == "")
            {
                MessageBox.Show("Seleccione Comuna", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cBox_comuna.Focus();
                return;
            }
            if (this.cBox_banco.Text == "")
            {
                MessageBox.Show("Seleccione Banco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cBox_banco.Focus();
                return;
            }
            if (this.txt_Ncta.Text == "")
            {
                MessageBox.Show("Ingrese un Número de Cuenta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Ncta.Focus();
                return;
            }
            if (this.cBox_cuenta.Text == "")
            {
                MessageBox.Show("Seleccione el Tipo de Cuenta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cBox_cuenta.Focus();
                return;
            }
            if (this.cBoxNacionalidad.Text == "")
            {
                MessageBox.Show("Seleccione Nacionalidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cBoxNacionalidad.Focus();
                return;
            }
            if (this.txt_email.Text == "")
            {
                MessageBox.Show("Ingrese E-Mail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_email.Focus();
                return;
            }
            if (!(radioButton1.Checked) || (radioButton2.Checked))
            {
                MessageBox.Show("Indique Sexo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.groupBox4.Focus();
                return;
            }
            if (this.cBox_est_civil.Text == "")
            {
                MessageBox.Show("Seleccione el Estado Civil", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cBox_est_civil.Focus();
                return;
            }
            objProfesor.rut = txt_rut.Text;
            objProfesor.dv = txt_dv.Text;
            objProfesor.nombre = txt_nombre.Text;
            objProfesor.apellido_p = txt_app.Text;
            objProfesor.apellido_m = txt_apm.Text;
            objProfesor.fecha_ncto = dateTimePicker1.Value;
            objProfesor.celular = int.Parse(txt_celular.Text);
            objProfesor.cod_comuna = int.Parse(cBox_comuna.SelectedValue.ToString());

            bool isChecked = radioButton1.Checked;
            if (isChecked)
            {
                Femenino = radioButton1.Text;
                objProfesor.sexo = radioButton1.Text;
            }
            else
            {
                Masculino = radioButton2.Text;
                objProfesor.sexo = radioButton2.Text;
            }
            objProfesor.mail = txt_email.Text;
            objProfesor.estado_civil = cBox_est_civil.Text;
            objProfesor.cod_nacio = int.Parse(cBoxNacionalidad.SelectedValue.ToString());
            objProfesor.cod_banco = int.Parse(cBox_banco.SelectedValue.ToString());
            objProfesor.num_cta = txt_Ncta.Text;
            objProfesor.cod_cta = int.Parse(cBox_cuenta.SelectedValue.ToString());
            MessageBox.Show(objProfesor.RegistrarProfesores(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ListarProfesores();
            Limpiar();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btn_ag_nac_Click(object sender, EventArgs e)
        {
            Nacionalidad obj = new Nacionalidad();
            obj.ShowDialog();
            llenarCombobox();
        }

        private void btn_ag_tipoCuenta_Click(object sender, EventArgs e)
        {
            TIPO_CUENTAS obj = new TIPO_CUENTAS();
            obj.ShowDialog();
            llenarCombobox();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            if (txt_rut.Text == "" || txt_dv.Text == "")
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
                MessageBox.Show("Ingrese celular", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_celular.Focus();
                return;
            }
            if (this.cBox_comuna.Text == "")
            {
                MessageBox.Show("Seleccione Comuna", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cBox_comuna.Focus();
                return;
            }
            if (this.cBox_banco.Text == "")
            {
                MessageBox.Show("Seleccione Banco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cBox_banco.Focus();
                return;
            }
            if (this.txt_Ncta.Text == "")
            {
                MessageBox.Show("Ingrese un Número de Cuenta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Ncta.Focus();
                return;
            }
            if (this.cBox_cuenta.Text == "")
            {
                MessageBox.Show("Seleccione el Tipo de Cuenta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cBox_cuenta.Focus();
                return;
            }
            if (this.cBoxNacionalidad.Text == "")
            {
                MessageBox.Show("Seleccione Nacionalidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cBoxNacionalidad.Focus();
                return;
            }
            if (this.txt_email.Text == "")
            {
                MessageBox.Show("Ingrese E-Mail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_email.Focus();
                return;
            }
            if (!(radioButton1.Checked) || (radioButton2.Checked))
            {
                MessageBox.Show("Indique Sexo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.groupBox4.Focus();
                return;
            }
            if (this.cBox_est_civil.Text == "")
            {
                MessageBox.Show("Seleccione el Estado Civil", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cBox_est_civil.Focus();
                return;
            }
            objProfesor.rut = txt_rut.Text;
            objProfesor.dv = txt_dv.Text;
            objProfesor.nombre = txt_nombre.Text;
            objProfesor.apellido_p = txt_app.Text;
            objProfesor.apellido_m = txt_apm.Text;
            objProfesor.fecha_ncto = dateTimePicker1.Value;
            objProfesor.celular = int.Parse(txt_celular.Text);
            objProfesor.cod_comuna = int.Parse(cBox_comuna.SelectedValue.ToString());

            bool isChecked = radioButton1.Checked;
            if (isChecked)
            {
                Femenino = radioButton1.Text;
                objProfesor.sexo = radioButton1.Text;
            }
            else
            {
                Masculino = radioButton2.Text;
                objProfesor.sexo = radioButton2.Text;
            }
            objProfesor.mail = txt_email.Text;
            objProfesor.estado_civil = cBox_est_civil.SelectedValue.ToString();
            objProfesor.cod_nacio = int.Parse(cBoxNacionalidad.SelectedValue.ToString());
            objProfesor.cod_banco = int.Parse(cBox_banco.SelectedValue.ToString());
            objProfesor.num_cta = txt_Ncta.Text;
            objProfesor.cod_cta = int.Parse(cBox_cuenta.SelectedValue.ToString());
            objProfesor.ActualizarProfesores();
            MessageBox.Show(objProfesor.ActualizarProfesores(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ListarProfesores();
            Limpiar();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            objProfesor.rut = txt_rut.Text;
            objProfesor.EliminarProfesores();
            MessageBox.Show(objProfesor.EliminarProfesores(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ListarProfesores();
            Limpiar();
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objProfesor.Buscar(txt_buscar.Text);
            dataGridView1.DataSource = objProfesor.Buscar(txt_busapp.Text);
            dataGridView1.DataSource = objProfesor.Buscar(txt_busapm.Text);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*txt_rut = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txt_nombre.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txt_
            
            btn_actualizar.Enabled = true;
            btn_eliminar.Enabled = true;
            btn_agregar.Enabled = false;*/
        }

        private void btn_excel_Click(object sender, EventArgs e)
        {
            global.GridAExcel(dataGridView1);
        }

        private void txt_celular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void txt_busapp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_busapm_KeyPress(object sender, KeyPressEventArgs e)
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

