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
    public partial class Planificaciones : Form
    {
       private ClaseProfesores p = new ClaseProfesores();
       private ClaseRamos r = new ClaseRamos();
       private ClaseCarreras c = new ClaseCarreras();
       private this.clasePl c = new ClaseCarreras();
        public Planificaciones()
        {
            InitializeComponent();
        }

        private void btn_ag_banco_Click(object sender, EventArgs e)
        {
            Buscar_Per obj = new Buscar_Per();
            obj.ShowDialog();
            paso();
            txt_rut.Focus();
          
        }
       private  void paso() {
         
           txt_rut.Text = Buscar_Per.rut;
           txt_dv.Text = Buscar_Per.dv;
           txt_nombre.Text = Buscar_Per.nombre;
           txt_app.Text = Buscar_Per.apellidop;
           txt_apm.Text = Buscar_Per.apellidom;
        
        }
        private void Planificaciones_Load(object sender, EventArgs e)
        {
            llenar();
        }
        private void llenar()
        {
           
            c_box_ramo.DataSource = r.Listado();
            c_box_ramo.ValueMember = "CODIGO";
            c_box_ramo.DisplayMember = "RAMO";

            c_box_carrera.DataSource = c.Listado();
            c_box_carrera.ValueMember = "CODIGO";
            c_box_carrera.DisplayMember = "CARRERA";
            comboBox1.Items.Add("1");
            comboBox1.Items.Add("2");
            
                       
         }
        private void txt_rut_KeyPress(object sender, KeyPressEventArgs e)
        {
            
         

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
                MessageBox.Show("Ingrese el Nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
          
            

            if (this.c_box_carrera.Text == "")
            {
                MessageBox.Show("Seleccione el Estado Civil", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                c_box_carrera.Focus();
                return;
            }
            if (this.c_box_ramo.Text == "")
            {
                MessageBox.Show("Seleccione el Estado Civil", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                c_box_ramo.Focus();
                return;
            }
            if (this.comboBox1.Text == "")
            {
                MessageBox.Show("Seleccione el Estado Civil", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox1.Focus();
                return;
            }
            if (this.txt_anio.Text == "")
            {
                MessageBox.Show("Seleccione el Estado Civil", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_anio.Focus();
                return;
            }
            if (this.txt_semestre.Text == "")
            {
                MessageBox.Show("Seleccione el Estado Civil", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_semestre.Focus();
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
    }
}
