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
       private ClaseProfesores objPro = new ClaseProfesores();
       private ClasePlanificacion objPlan = new ClasePlanificacion();
       private ClaseCarreras objCa = new ClaseCarreras();
       private ClaseRamos objRam = new ClaseRamos();
      // ClaseConfiguracion objConfig = new ClaseConfiguracion();
       
       
        public Planificaciones()
        {
            InitializeComponent();
        }
        private void llenarCombo(){
            cBox_seccion.Items.Add("1");
            cBox_seccion.Items.Add("2");
    }
        private void btn_ag_pro_Click(object sender, EventArgs e)
        {
            Buscar_Profesor obj = new Buscar_Profesor();
            obj.ShowDialog();
            txt_rut.Text = Buscar_Profesor.rut;
            DataTable dt = new DataTable();
            dt = objPro.Cargar(txt_rut.Text);

            if (dt.Rows.Count == 1)
            {
                txt_dv.Text = dt.Rows[0].ItemArray[1].ToString();
                txt_nombre.Text = dt.Rows[0].ItemArray[2].ToString();
                txt_app.Text = dt.Rows[0].ItemArray[3].ToString();
                txt_apm.Text = dt.Rows[0].ItemArray[4].ToString();
            }

        }
        private void Limpiar() {
            txt_rut.Text = "";
            txt_nombre.Text = "";
            txt_cod_asig.Text = "";
            txt_cod_carr.Text = "";
            txt_dv.Text = "";
            txt_horas.Text = "";
            txt_apm.Text = "";
            txt_app.Text = "";
            txt_nom_carr.Text = "";
            txt_nom_asig.Text = "";
        }
        private void ListarPlanificaciones()
        {
            dataGridView1.DataSource = objPlan.Listado();
        }
      
        private void Planificaciones_Load(object sender, EventArgs e)
        {
            Configuracion.datos();
            ListarPlanificaciones();
            llenarCombo();
            label_anio.Text = Configuracion.anio.ToString();
            labelperiodo.Text = Configuracion.periodo.ToString();
        }
         private void btn_ag_carre_Click(object sender, EventArgs e)
        {
            BuscarCarrera obj = new BuscarCarrera();
            obj.ShowDialog();
            txt_cod_carr.Text = BuscarCarrera.codigo;
            DataTable dt = new DataTable();
            dt = objCa.Cargar(txt_cod_carr.Text);

            if (dt.Rows.Count == 1)
            {
                txt_nom_carr.Text= dt.Rows[0].ItemArray[1].ToString();
            }

        }
        private void btn_ag_asig_Click(object sender, EventArgs e)
        {
            Buscar_Ramos obj = new Buscar_Ramos();
            obj.ShowDialog();
            txt_cod_asig.Text = Buscar_Ramos.codigo;
            
            DataTable dt = new DataTable();
            dt = objRam.Cargar(txt_cod_asig.Text);

            if (dt.Rows.Count == 1)
            {

                txt_nom_asig.Text = dt.Rows[0].ItemArray[1].ToString();
               
            }
          
        }
        

        private void btn_guardar_Click_1(object sender, EventArgs e)
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
                MessageBox.Show("Ingrese Apellido materno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_apm.Focus();
                return;
            }

            objPlan.rut = txt_rut.Text;
            objPlan.codigoC = txt_cod_carr.Text;
            objPlan.codigoR = txt_cod_asig.Text;
            objPlan.seccion = int.Parse(cBox_seccion.Text);
            objPlan.anio = int.Parse(label_anio.Text);
            objPlan.periodo = int.Parse(labelperiodo.Text);
            MessageBox.Show(objPlan.RegistrarPlanificacion(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ListarPlanificaciones();
            Limpiar();
        }

       

        
    }
}
